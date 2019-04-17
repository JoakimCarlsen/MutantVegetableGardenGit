using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOff : MonoBehaviour
{
    public MusicSwitcher_GardenAr musicSwitcher;

    // Start is called before the first frame update
    public void turnMusicOff()
    {
        musicSwitcher.mainCounter = 1;
        musicSwitcher.SwitchMusic();
    }

}
