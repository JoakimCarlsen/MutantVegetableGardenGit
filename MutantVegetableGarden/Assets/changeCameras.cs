using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeCameras : MonoBehaviour
{
    public bool arOn = false;

    private GameObject arCam;
    private GameObject digiCam;
    private Button arBut;

    public Color arOnColor;
    public Color arOffColor;

    // Start is called before the first frame update
    void Start()
    {
        arCam = GameObject.Find("ARCamera");
        digiCam = GameObject.Find("Main Camera");
        arBut = GameObject.Find("AR_On_Off_Button").GetComponent<Button>();

        if (arOn){
            digiCam.SetActive(false);
            arBut.GetComponent<Image>().color = arOnColor;
        }
        else{
            arCam.SetActive(false);
            arBut.GetComponent<Image>().color = arOffColor;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }




    public void arToggle()
    {
        digiCam.SetActive(!digiCam.activeSelf);
        arCam.SetActive(!arCam.activeSelf);

        if(arBut.GetComponent<Image>().color == arOffColor)
            arBut.GetComponent<Image>().color = arOnColor;
        else
            arBut.GetComponent<Image>().color = arOffColor;

    }
}
