using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    private Camera cam;
    private int rOrB = 0;


    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("ARCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         Vector3 mousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.farClipPlane);
    //         Vector3 mousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane);
    //         Vector3 mousePosF = cam.ScreenToWorldPoint(mousePosFar);
    //         Vector3 mousePosN = cam.ScreenToWorldPoint(mousePosNear);

    //         RaycastHit hit;

    //         if (Physics.Raycast(mousePosN, mousePosF - mousePosN, out hit))
    //         {
    //             if (rOrB == 0)
    //             {
    //                 hit.transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    //                 rOrB = 1;
    //             }
    //             else if (rOrB == 1)
    //             {
    //                 hit.transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
    //                 rOrB = 0;
    //             }
    //         }
    //     }
    // }


    public void CastRay()
    {
        Vector3 mousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.farClipPlane);
        Vector3 mousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane);
        Vector3 mousePosF = cam.ScreenToWorldPoint(mousePosFar);
        Vector3 mousePosN = cam.ScreenToWorldPoint(mousePosNear);

        RaycastHit hit;

        if (Physics.Raycast(mousePosN, mousePosF - mousePosN, out hit))
        {
            if (rOrB == 0)
            {
                hit.transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                rOrB = 1;
            }
            else if (rOrB == 1)
            {
                hit.transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
                rOrB = 0;
            }
        }
    }
}
