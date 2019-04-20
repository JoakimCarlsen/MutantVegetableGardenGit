using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateManager : MonoBehaviour
{
    public GameObject introCanvas;
    public Animator introWindow;

    public GameObject madelaineCanvas;
    public Animator madelaineParent;
    public int madelaineCounter = 0;

    public GameObject speechSprite;
    public Animator speechPopUp;
    public int speechCounter = 0;
    public GameObject speech01;
    public GameObject speech02;
    public GameObject speech03;
    public GameObject speech04;


    public GameObject bigbeeSprite;
    public Animator bigbeeAnimator;

    public float windowTimer = 0f;
    public float madelaineTimer = 0f;
    public float madelaineOutTimer = 0f;
    public float speechTimer = 0f;
    public float bigbeeTimer = 0f;

    // Start is called before the first frame update
    public void SwipeWindow()
    {
        introWindow.Play("I_SwipeUp");
        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {
        if(madelaineCounter == 0)
        {
            yield return new WaitForSeconds(madelaineTimer);
            MadelaineIn();
            yield return new WaitForSeconds(speechTimer);
            SpeechPopper();
            yield return new WaitForSeconds(bigbeeTimer);
            BigbeeEnter();
            yield return new WaitForSeconds(windowTimer);
            introCanvas.SetActive(false);
        }
       
        else if(madelaineCounter == 4)
        {
            yield return new WaitForSeconds(madelaineOutTimer);
            madelaineCanvas.SetActive(false);
        }

    }

    public void MadelaineIn()
    {
        madelaineParent.Play("M_Enter");
    }

    public void SpeechPopper()
    {
        speechPopUp.Play("S_Pop");
    }

    public void SpeechOut()
    {
        speechPopUp.Play("S_Out");
    }

    public void BigbeeEnter()
    {
        bigbeeAnimator.Play("B_Enter");
    }

    public void MadelaineOut()
    {
        madelaineCounter++;
        
        if (madelaineCounter == 1)
        {
            speech01.SetActive(false);
            speech02.SetActive(true);
        }

        else if (madelaineCounter == 2)
        {
            speech02.SetActive(false);
            speech03.SetActive(true);
        }

        else if (madelaineCounter == 3)
        {
            speech03.SetActive(false);
            speech04.SetActive(true);
        }

        else if(madelaineCounter == 4)
        {
            SpeechOut();
            madelaineParent.Play("M_Exit");
            StartCoroutine(LateCall());

        }

    }

}
