using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public RectTransform potPanel;

    public string itemDescription;

    public GameObject MixingBenchGO;

    private GameObject inventory;

    void Start()
    {
        MixingBenchGO = GameObject.Find("MixingBench");
        inventory = GameObject.Find("GameManager");
    }


    public void OnDrag(PointerEventData eventData)
    {
        // if statement for checking if there is more than 0 of the specific item, itemName is placeholder for the int in inventory: if(inventory.GetComponent<Inventory>().itemName > 0)
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        if (RectTransformUtility.RectangleContainsScreenPoint(potPanel, Input.mousePosition))
        {
            Debug.Log("Dropped item");
            transform.localPosition = Vector3.zero;
            MixingBenchGO.GetComponent<CreatureCreater>().AddToPot(itemDescription);
            // subtract 1 from inventory.GetComponent<Inventory>().nameofthewvariableyouwanttoremovefrom
        }
        else transform.localPosition = Vector3.zero;
    }
}
