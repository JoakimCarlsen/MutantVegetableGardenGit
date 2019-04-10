﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureCreater : MonoBehaviour
{
    public Sprite[] bodies;
    public Sprite[] leftArms;
    public Sprite[] rightArms;
    public Sprite[] leftLegs;
    public Sprite[] rightLegs;
    public Sprite[] faces;

    public string[] possibleIngredients;

    public List<string> ObjInPot = new List<string>();
    private List<GameObject> bodyPart = new List<GameObject>();

    public GameObject[] plantSkeleton;
    public GameObject garden;


    public void AddToPot(string obj)
    {
        ObjInPot.Add(obj);
        if (ObjInPot.Count == 3)
        {
            this.gameObject.GetComponent<ShakeScript>().canMix = true;
        }
    }

    public void CreateCreature()
    {
        // Body
        for (int i = 0; i < possibleIngredients.Length; i++)
        {
            if (ObjInPot[0].Contains(possibleIngredients[i]))
            {
                // if you find a way to randomise position of the spawn of creatures, change garden.transform.position.x (and .z), to what ever x and z position the random should use
                GameObject newSkeleton = Instantiate(plantSkeleton[i], new Vector3(garden.transform.position.x, garden.transform.position.y + 5.66f, garden.transform.position.z), Quaternion.identity);
                newSkeleton.transform.parent = garden.transform;

                foreach (Transform child in newSkeleton.transform)
                {
                    bodyPart.Add(child.gameObject);
                }
                bodyPart[0].GetComponent<SpriteRenderer>().sprite = bodies[i];
            }
        }

        // Arms & Legs
        for (int i = 0; i < possibleIngredients.Length; i++)
        {
            if (ObjInPot[1].Contains(possibleIngredients[i]))
            {
                // Left leg
                bodyPart[1].GetComponent<SpriteRenderer>().sprite = leftLegs[i];
                // Right leg
                bodyPart[2].GetComponent<SpriteRenderer>().sprite = rightLegs[i];

                // Left arm
                bodyPart[3].GetComponent<SpriteRenderer>().sprite = leftArms[i];
                // Right arm
                bodyPart[4].GetComponent<SpriteRenderer>().sprite = rightArms[i];
            }
        }

        // Face
        for (int i = 0; i < possibleIngredients.Length; i++)
        {
            if (ObjInPot[2].Contains(possibleIngredients[i]))
            {
                bodyPart[5].GetComponent<SpriteRenderer>().sprite = faces[i];
            }
        }

        // Empties the list, for new creatures to be added
        ObjInPot.Clear();
    }
}