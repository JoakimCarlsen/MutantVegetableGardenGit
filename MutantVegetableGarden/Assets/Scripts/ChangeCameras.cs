using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCameras : MonoBehaviour
{
    public bool arOn = false;

    private GameObject ar;
    private GameObject mix;
    private GameObject garden;
    private GameObject arRayBut;
    private Button arBut;
    private Button gardenBut;
    private Button mixingBut;
    public GameObject mixingPanel;

    //public Color arOnColor;
    //public Color arOffColor;

    // Start is called before the first frame update
    void Start()
    {
        ar = GameObject.Find("AR");
        mix = GameObject.Find("MixingBench");
        garden = GameObject.Find("Garden");
        arRayBut = GameObject.Find("RayButton");
        arBut = GameObject.Find("ARButton").GetComponent<Button>();
        gardenBut = GameObject.Find("GardenButton").GetComponent<Button>();
        mixingBut = GameObject.Find("MixingButton").GetComponent<Button>();
        //mixingPanel = GameObject.Find("MixingUI");

        if (arOn)
        {
            garden.SetActive(false);
            mix.SetActive(false);
            ar.SetActive(true);
            //arBut.GetComponent<Image>().color = arOnColor;
            arRayBut.SetActive(true);
            arBut.interactable = false;
            gardenBut.interactable = true;
            mixingBut.interactable = true;
            // Garden UI in next line;
            mixingPanel.SetActive(false);
        }
        else
        {
            if (ar != null)
                ar.SetActive(false);
            //arBut.GetComponent<Image>().color = arOffColor;
            garden.SetActive(true);
            mix.SetActive(false);
            arRayBut.SetActive(false);
            arBut.interactable = true;
            gardenBut.interactable = false;
            mixingBut.interactable = true;
            // Garden UI in next line;
            mixingPanel.SetActive(false);
        }
    }


    public void AR_On()
    {
        garden.SetActive(false);
        mix.SetActive(false);
        ar.SetActive(true);
        arRayBut.SetActive(true);
        arBut.interactable = false;
        gardenBut.interactable = true;
        mixingBut.interactable = true;
        mixingPanel.SetActive(false);
    }

    public void Garden_On()
    {
        garden.SetActive(true);
        mix.SetActive(false);
        ar.SetActive(false);
        arRayBut.SetActive(false);
        arBut.interactable = true;
        gardenBut.interactable = false;
        mixingBut.interactable = true;
        mixingPanel.SetActive(false);
    }

    public void Mixing_On()
    {
        garden.SetActive(false);
        mix.SetActive(true);
        ar.SetActive(false);
        arRayBut.SetActive(false);
        arBut.interactable = true;
        gardenBut.interactable = true;
        mixingBut.interactable = false;
        // Mixing UI in next line;
        mixingPanel.SetActive(true);
    }
}
