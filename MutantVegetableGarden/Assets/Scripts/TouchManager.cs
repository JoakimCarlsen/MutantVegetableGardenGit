using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchManager : MonoBehaviour
{
    private Camera cam;
    private int rOrB = 0;
    private GameObject inventory;
    public Text[] inventoryTexts;


    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("ARCamera") != null)
            cam = GameObject.Find("ARCamera").GetComponent<Camera>();

        inventory = GameObject.Find("GameManager");
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
            Pickup(hit.transform.gameObject.GetComponent<IngredientType>().type);

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

    void Pickup(string type)
    {
        if (type == "water")
        {
            inventory.GetComponent<Inventory>().water += 1;
            inventoryTexts[0].text = "Water: " + inventory.GetComponent<Inventory>().water;
        }
        else if (type == "seeds")
        {
            inventory.GetComponent<Inventory>().seeds += 1;
            inventoryTexts[1].text = "Seeds: " + inventory.GetComponent<Inventory>().seeds;
        }
        else if (type == "potato")
        {
            inventory.GetComponent<Inventory>().potatoes += 1;
            inventoryTexts[2].text = "Potatoes: " + inventory.GetComponent<Inventory>().potatoes;
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