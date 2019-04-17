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
       
        else if(madelaineCounter == 1)
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
        madelaineParent.Play("M_Exit");
        madelaineCounter = 1;
        StartCoroutine(LateCall());

    }

}
