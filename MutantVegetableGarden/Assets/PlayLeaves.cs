using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayLeaves : MonoBehaviour
{
    public Camera cam;

    public string particleSource;

    public ParticleSystem leavesParticles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //        Vector3 mousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.farClipPlane);
        //        Vector3 mousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane);
        //        Vector3 mousePosF = cam.ScreenToWorldPoint(mousePosFar);
        //        Vector3 mousePosN = cam.ScreenToWorldPoint(mousePosNear);
        //
        //        RaycastHit hit;
        //
        //        if (Physics.Raycast(mousePosN, mousePosF - mousePosN, out hit))
        //        {
        //            if (gameObject.tag == "LeafPuffer")
        //            {
        //                LeavesBurster();
        //            }
        //        }

            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {

                //if (hit.collider.tag == "LeafPuffer")
                if (hit.collider.name == particleSource)
                    {
                    LeavesBurster();
                    }
                }
            }

    }

    public void CastRay()
    {
       
    }

    public void LeavesBurster()
    {
        if (leavesParticles.isPlaying)
        {
            leavesParticles.Stop();
        }

        else
        {
            leavesParticles.Play();
        }

    }

}
