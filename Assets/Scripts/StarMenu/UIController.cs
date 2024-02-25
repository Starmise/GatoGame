using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Slider _musicSlider;

    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;

    public void ToggleMsuic()
    {
        AudioController.Instance.ToggleMusic();
    }

    public void MusicVolume()
    {
        AudioController.Instance.MusicVolume(_musicSlider.value);
    }

    public void ShowSettings()
    {
        objeto1.SetActive(true);
        objeto2.SetActive(true);
        objeto3.SetActive(true);
        objeto4.SetActive(true);
    }

    public void HideSettings()
    {
        objeto1.SetActive(false);
        objeto2.SetActive(false);
        objeto3.SetActive(false);
        objeto4.SetActive(false);
    }
}
