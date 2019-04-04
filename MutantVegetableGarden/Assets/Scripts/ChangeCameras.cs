using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCameras : MonoBehaviour
{
    public bool arOn = false;

    private GameObject arCam;
    private GameObject digiCam;
    private Button arBut;
    public GameObject arRayBut;

    public Color arOnColor;
    public Color arOffColor;

    // Start is called before the first frame update
    void Start()
    {
        arCam = GameObject.Find("ARCamera");
        digiCam = GameObject.Find("Main Camera");
        arRayBut = GameObject.Find("RayButton");
        arBut = GameObject.Find("AR_On_Off_Button").GetComponent<Button>();

        if (arOn){
            digiCam.SetActive(false);
            arBut.GetComponent<Image>().color = arOnColor;
            arRayBut.SetActive(true);
        }
        else{
            arCam.SetActive(false);
            arBut.GetComponent<Image>().color = arOffColor;
            arRayBut.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }




    public void ArToggle()
    {
        digiCam.SetActive(!digiCam.activeSelf);
        arCam.SetActive(!arCam.activeSelf);
        arRayBut.SetActive(!arRayBut.activeSelf);

        if(arBut.GetComponent<Image>().color == arOffColor)
            arBut.GetComponent<Image>().color = arOnColor;
        else
            arBut.GetComponent<Image>().color = arOffColor;

    }
}
