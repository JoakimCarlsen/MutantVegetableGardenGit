using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDrag : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public RectTransform potPanel;

    public string itemDescription;

    public GameObject MixingBenchGO;

    private GameObject inventory;

    public Text[] inventoryTexts;

    public GameObject[] currentIngredients;

    public enum ingredientPossibilities { type1, type2, type3, type4, type5, type6 }
    public ingredientPossibilities thisObject;

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
            if (thisObject == ingredientPossibilities.type1)
            {
                inventory.GetComponent<Inventory>().item1 -= 1;
                inventoryTexts[0].text = "" + inventory.GetComponent<Inventory>().item1;
                if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 1)
                {
                    currentIngredients[0].GetComponent<Image>().enabled = true;
                    currentIngredients[0].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 2)
                {
                    currentIngredients[1].GetComponent<Image>().enabled = true;
                    currentIngredients[1].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 3)
                {
                    currentIngredients[2].GetComponent<Image>().enabled = true;
                    currentIngredients[2].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
            }
            else if (thisObject == ingredientPossibilities.type2)
            {
                inventory.GetComponent<Inventory>().item2 -= 1;
                inventoryTexts[1].text = "" + inventory.GetComponent<Inventory>().item2;
                if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 1)
                {
                    currentIngredients[0].GetComponent<Image>().enabled = true;
                    currentIngredients[0].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 2)
                {
                    currentIngredients[1].GetComponent<Image>().enabled = true;
                    currentIngredients[1].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 3)
                {
                    currentIngredients[2].GetComponent<Image>().enabled = true;
                    currentIngredients[2].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
            }
            else if (thisObject == ingredientPossibilities.type3)
            {
                inventory.GetComponent<Inventory>().item3 -= 1;
                inventoryTexts[2].text = "" + inventory.GetComponent<Inventory>().item3;
                if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 1)
                {
                    currentIngredients[0].GetComponent<Image>().enabled = true;
                    currentIngredients[0].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 2)
                {
                    currentIngredients[1].GetComponent<Image>().enabled = true;
                    currentIngredients[1].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 3)
                {
                    currentIngredients[2].GetComponent<Image>().enabled = true;
                    currentIngredients[2].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
            }
            else if (thisObject == ingredientPossibilities.type4)
            {
                inventory.GetComponent<Inventory>().item4 -= 1;
                inventoryTexts[3].text = "" + inventory.GetComponent<Inventory>().item4;
                if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 1)
                {
                    currentIngredients[0].GetComponent<Image>().enabled = true;
                    currentIngredients[0].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 2)
                {
                    currentIngredients[1].GetComponent<Image>().enabled = true;
                    currentIngredients[1].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 3)
                {
                    currentIngredients[2].GetComponent<Image>().enabled = true;
                    currentIngredients[2].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
            }
            else if (thisObject == ingredientPossibilities.type5)
            {
                inventory.GetComponent<Inventory>().item5 -= 1;
                inventoryTexts[4].text = "" + inventory.GetComponent<Inventory>().item5;
                if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 1)
                {
                    currentIngredients[0].GetComponent<Image>().enabled = true;
                    currentIngredients[0].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 2)
                {
                    currentIngredients[1].GetComponent<Image>().enabled = true;
                    currentIngredients[1].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 3)
                {
                    currentIngredients[2].GetComponent<Image>().enabled = true;
                    currentIngredients[2].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
            }
            else if (thisObject == ingredientPossibilities.type6)
            {
                inventory.GetComponent<Inventory>().item6 -= 1;
                inventoryTexts[5].text = "" + inventory.GetComponent<Inventory>().item6;
                if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 1)
                {
                    currentIngredients[0].GetComponent<Image>().enabled = true;
                    currentIngredients[0].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 2)
                {
                    currentIngredients[1].GetComponent<Image>().enabled = true;
                    currentIngredients[1].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
                else if (MixingBenchGO.GetComponent<CreatureCreater>().ObjInPot.Count == 3)
                {
                    currentIngredients[2].GetComponent<Image>().enabled = true;
                    currentIngredients[2].GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
                }
            }
        }
        else transform.localPosition = Vector3.zero;
    }
}
