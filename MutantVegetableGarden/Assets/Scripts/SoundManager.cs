using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource start;
    public AudioSource back;
    public AudioSource ui;
    public AudioSource ing01;
    public AudioSource ing02;
    public AudioSource ing03;
    public AudioSource box;
    public AudioSource creature;


    // Start is called before the first frame update
    public void StartButton()
    {
        start.Play();
    }

    public void BackButton()
    {
        back.Play();
    }

    public void UiButton()
    {
        ui.Play();
    }

    public void Ing01Button()
    {
        ing01.Play();
    }

    public void Ing02Button()
    {
        ing02.Play();
    }

    public void Ing03Button()
    {
        ing03.Play();
    }

    public void BoxOpen()
    {
        box.Play();
    }

    public void CreatureCompletion()
    {
        creature.Play();
    }
}
