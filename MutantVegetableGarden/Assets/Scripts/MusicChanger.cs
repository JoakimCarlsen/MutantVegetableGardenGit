using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChanger : MonoBehaviour
{
    public AudioSource introTrack;
    public GameObject introObject;
    public AudioSource gardenTrack;
    public GameObject gardenObject;
    public float sec = 0f;
    public float introVar = 0f;
    public float gardenVar = 0f;

    public AudioSource speechBubbleSound;

    // Use this for initialization
    public void TransitionMusic()
    {
        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {
        //yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;
        yield return new WaitForSeconds(sec);
        introTrack.volume -= introVar;


        introObject.SetActive(false);

        gardenTrack.Play();
        gardenTrack.volume += gardenVar;
        yield return new WaitForSeconds(sec);
        gardenTrack.volume += gardenVar;
        yield return new WaitForSeconds(sec);
        gardenTrack.volume += gardenVar;
        yield return new WaitForSeconds(sec);
        gardenTrack.volume += gardenVar;
        yield return new WaitForSeconds(sec);
        gardenTrack.volume += gardenVar;
        yield return new WaitForSeconds(sec);
        gardenTrack.volume += gardenVar;
        yield return new WaitForSeconds(sec);
        gardenTrack.volume += gardenVar;
        //yield return new WaitForSeconds(sec);
        //gardenTrack.volume += gardenVar;
        //yield return new WaitForSeconds(sec);
        //gardenTrack.volume += gardenVar;
        //yield return new WaitForSeconds(sec);
        //gardenTrack.volume += gardenVar;
        //yield return new WaitForSeconds(sec);
        //gardenTrack.volume += gardenVar;
    }

    public void speechPoppingUp()
    {
        speechBubbleSound.Play();
    }
}
