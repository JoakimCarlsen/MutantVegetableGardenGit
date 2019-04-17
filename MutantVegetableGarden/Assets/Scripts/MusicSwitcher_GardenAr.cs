using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher_GardenAr : MonoBehaviour
{
    public AudioSource gardenMusic;

    public int mainCounter = 2;
    //public int secondCounter = 0;

    public float sec = 0f;
    public float gardenVar = 0f;


    // Add to counters and transform them
    public void SwitchMusic()
    {
        //mainCounter++;
        //secondCounter++;

        //if(mainCounter == 3)
        //{
        //    mainCounter = 0;
        //}

        //if(secondCounter > 2)
        //{
        //    mainCounter++;
        //}

        StartCoroutine(LateCall());

    }

    // Update is called once per frame
    IEnumerator LateCall()
    {
        if(mainCounter == 1)
        {
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume -= gardenVar;
        }
        
        if(mainCounter == 2)
        {
            yield return new WaitForSeconds(sec);
            gardenMusic.volume += gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume += gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume += gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume += gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume += gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume += gardenVar;
            yield return new WaitForSeconds(sec);
            gardenMusic.volume += gardenVar;
            //yield return new WaitForSeconds(sec);
            //gardenMusic.volume += gardenVar;
            //yield return new WaitForSeconds(sec);
            //gardenMusic.volume += gardenVar;
            //yield return new WaitForSeconds(sec);
            //gardenMusic.volume += gardenVar;
            //yield return new WaitForSeconds(sec);
            //gardenMusic.volume += gardenVar;
        }

    }
}
