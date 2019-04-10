using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public RectTransform potPanel;

    public string itemDescription;

    public GameObject MixingBenchGO;

    void Start()
    {
        MixingBenchGO = GameObject.Find("MixingBench");
    }


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        if (RectTransformUtility.RectangleContainsScreenPoint(potPanel, Input.mousePosition))
        {
            Debug.Log("Dropped item");
            transform.localPosition = Vector3.zero;
        }
        else transform.localPosition = Vector3.zero;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
