using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingredientCountdown : MonoBehaviour
{
    public float sec = 30f;
    void Start()
    {

    }

    public void StartCountdown(GameObject obj){
        StartCoroutine(LateCall(obj));
    }

    IEnumerator LateCall(GameObject obj)
    {
        obj.GetComponent<BoxCollider>().enabled = false;

        yield return new WaitForSeconds(sec);

        obj.GetComponent<BoxCollider>().enabled = true;
    }
}
