using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateAndTransformCreature : MonoBehaviour
{
    public GameObject skeletonMaster;
    public float xValue;
    public float yValue;
    public float zValue;
    public int instantiateThreshold = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
//        instantiateThreshold++;
//        if (instantiateThreshold == 1)
//        {
//            GameObject skeletonCopy = Instantiate<GameObject>(skeletonMaster);
//            skeletonCopy.transform.position = new Vector3(xValue, yValue, zValue);
//            //instantiateThreshold++;
//        }
    }
}
