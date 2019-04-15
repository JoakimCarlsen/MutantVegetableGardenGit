using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Plant_AI : MonoBehaviour
{
    NavMeshAgent plant;
    NavMeshPath path;
    public float timeForNewPath;
    bool inCorountine = false;
    Vector3 target;
    bool validPath;
    bool runOnce;

    public enum State
    {
        Idle,
        Moving
    }
    public State _state;

    // Start is called before the first frame update
    void Start()
    {
        plant = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
        _state = State.Moving;
        GetNewPath();
    }

    // Update is called once per frame
    void Update()
    {
        switch (_state)
        {
            case State.Moving:
                MoveAround();
                if (!runOnce)
                {
                    plant.isStopped = false;
                    StartCoroutine(ChangeState(State.Idle));
                }
                break;
            case State.Idle:
                if (!runOnce)
                {
                    plant.isStopped = true;
                    StartCoroutine(ChangeState(State.Moving));
                }
                break;
        }
    }

    Vector3 GetNewRandomPosition()
    {
        float x = Random.Range(-20, 20);
        float z = Random.Range(-20, 20);

        Vector3 pos = new Vector3(x, transform.position.y, z);
        return pos;
    }

    IEnumerator TimeBeforeNewPath()
    {
        inCorountine = true;
        yield return new WaitForSeconds(timeForNewPath);
        GetNewPath();
        // validPath = plant.CalculatePath(target, path);
        // if (!validPath)
        // {

        // }

        // while (!validPath)
        // {
        //     yield return new WaitForSeconds(0.01f);
        //     GetNewPath();
        //     validPath = plant.CalculatePath(target, path);
        // }
        inCorountine = false;
    }

    void GetNewPath()
    {
        target = GetNewRandomPosition();
        plant.SetDestination(target);
    }

    private void OnEnable()
    {
        inCorountine = false;
    }

    private void MoveAround()
    {
        if (!inCorountine)
        {
            StartCoroutine(TimeBeforeNewPath());
        }
    }

    IEnumerator ChangeState(State _newState)
    {
        runOnce = true;
        float tempTime = Random.Range(2f, 10f);
        yield return new WaitForSeconds(tempTime);
        _state = _newState;
        runOnce = false;
    }
}