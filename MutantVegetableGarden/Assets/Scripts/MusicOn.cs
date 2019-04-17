using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOn : MonoBehaviour
{
    public MusicSwitcher_GardenAr musicSwitcher;
    public GameObject musicManager;
    //public int count;

    // Start is called before the first frame update
    public void turnMusicOn()
    {
        //count = musicSwitcher.mainCounter.GetType;

        //musicManager.GetComponent<MusicSwitcher_GardenAr>;

        //int count = musicSwitcher.GetComponent<int> as count;

        int count = musicSwitcher.mainCounter;

        if(count == 2)
        {
            Debug.Log("Do not increase music volume");
        }

        else
        {
            musicSwitcher.mainCounter = 2;
            musicSwitcher.SwitchMusic();
        }
        
    }

}
