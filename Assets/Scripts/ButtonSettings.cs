using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSettings : MonoBehaviour
{
    public GameObject SettingsButton;
    public GameObject PlayButton;
    public GameObject SettingsWindow;

    public void OpenSettingsWindow()
    {
        SettingsButton.SetActive(false);
        PlayButton.SetActive(false);
        SettingsWindow.SetActive(true);
    }

    public void CloseSettingsWindow()
    {
        SettingsButton.SetActive(true);
        PlayButton.SetActive(true);
        SettingsWindow.SetActive(false);
    }
}
