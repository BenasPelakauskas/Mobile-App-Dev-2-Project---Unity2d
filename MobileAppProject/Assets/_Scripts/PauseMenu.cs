using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject Pausemenu, PauseButton;

    public void Pause()
    {
        Pausemenu.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {   // Reverse so menu dissapeares & pause button appears
        Pausemenu.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale =1;
    }
}