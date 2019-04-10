using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrop : MonoBehaviour, IDropHandler
{
    public RectTransform potPanel;

    public void OnDrop(PointerEventData eventData)
    {
        print("srdyd");
        RectTransform potPanel = transform as RectTransform;
        if (!RectTransformUtility.RectangleContainsScreenPoint(potPanel, Input.mousePosition))
        {
            Debug.Log("Dropped item");
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
