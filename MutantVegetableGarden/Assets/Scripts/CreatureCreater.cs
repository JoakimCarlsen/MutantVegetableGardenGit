using System.Collections;
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
    public List<GameObject> bodyPart = new List<GameObject>();

    public GameObject[] plantSkeleton;
    public GameObject garden;

    float xValue;
    float zValue;

    public void Start()
    {

    }

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
                //The following line was the original. The new one can spawn the creature in a "random" position. But the randome location only happens once; after the first creature is spawned, the position won't change.
                //GameObject newSkeleton = Instantiate(plantSkeleton[i], new Vector3(garden.transform.position.x, garden.transform.position.y + 5.66f, garden.transform.position.z), Quaternion.identity);
                xValue = Random.Range(-40f, 20f); //(-52, 14);
                zValue = Random.Range(-15f, -40f); //(-23, 12);
                GameObject newSkeleton = Instantiate(plantSkeleton[i], new Vector3(xValue, garden.transform.position.y + 5.66f, zValue), Quaternion.identity);
                newSkeleton.transform.parent = garden.transform;
                bodyPart.Clear();

                foreach (Transform child in newSkeleton.transform)
                {
                    if (child.transform.childCount == 0)
                    {
                        bodyPart.Add(child.gameObject);
                    }
                    else
                    {
                        bodyPart.Add(child.GetChild(0).transform.gameObject);
                    }
                    // if (child.gameObject.GetComponent<SpriteRenderer>() != null)
                    //     bodyPart.Add(child.gameObject);
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