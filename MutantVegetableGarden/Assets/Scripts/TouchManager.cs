using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchManager : MonoBehaviour
{
    private Camera cam;
    private int rOrB = 0;
    private GameObject manager;
    public Text[] inventoryTexts;


    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("ARCamera") != null)
            cam = GameObject.Find("ARCamera").GetComponent<Camera>();

        manager = GameObject.Find("GameManager");
    }

    public void CastRay()
    {
        Vector3 mousePosFar = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.farClipPlane);
        Vector3 mousePosNear = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane);
        Vector3 mousePosF = cam.ScreenToWorldPoint(mousePosFar);
        Vector3 mousePosN = cam.ScreenToWorldPoint(mousePosNear);

        RaycastHit hit;

        if (Physics.Raycast(mousePosN, mousePosF - mousePosN, out hit))
        {
            //Pickup(hit.transform.gameObject.GetComponent<IngredientType>().type);
            //manager.GetComponent<ingredientCountdown>().StartCountdown(hit.transform.gameObject);

            // Add countdown feedback for the ingredients

            hit.transform.gameObject.GetComponent<destroyBox>().BreakBox();

            // if (rOrB == 0)
            // {
            //     hit.transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            //     rOrB = 1;
            // }
            // else if (rOrB == 1)
            // {
            //     hit.transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
            //     rOrB = 0;
            // }
        }
    }

    void Pickup(string type)
    {
        if (type == "type1")
        {
            manager.GetComponent<Inventory>().item1 += 1;
            inventoryTexts[0].text = "" + manager.GetComponent<Inventory>().item1;
        }
        else if (type == "type2")
        {
            manager.GetComponent<Inventory>().item2 += 1;
            inventoryTexts[1].text = "" + manager.GetComponent<Inventory>().item2;
        }
        else if (type == "type3")
        {
            manager.GetComponent<Inventory>().item3 += 1;
            inventoryTexts[2].text = "" + manager.GetComponent<Inventory>().item3;
        }
        else if (type == "type4")
        {
            manager.GetComponent<Inventory>().item4 += 1;
            inventoryTexts[3].text = "" + manager.GetComponent<Inventory>().item4;
        }
        else if (type == "type5")
        {
            manager.GetComponent<Inventory>().item5 += 1;
            inventoryTexts[4].text = "" + manager.GetComponent<Inventory>().item5;
        }
        else if (type == "type6")
        {
            manager.GetComponent<Inventory>().item6 += 1;
            inventoryTexts[5].text = "" + manager.GetComponent<Inventory>().item6;
        }
    }
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