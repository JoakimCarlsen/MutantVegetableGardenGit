using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientPickup : MonoBehaviour
{
    private bool canPickUp = true;
    private int cooldown = 120;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void PickUpItem(){
        // Returns out of function if item cannot be picked up
        if (!canPickUp)
            return;


        canPickUp = false;
        
        // time before item can be picked up again
        Invoke("CoolDown", cooldown);
    }

    void CoolDown(){
        canPickUp = true;
    }
}
