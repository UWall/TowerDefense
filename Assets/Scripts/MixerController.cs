using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MixerController : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider musicValue;
    public Slider efeitosValue;
    public Slider masterVol;


    private void Start()
    {
        PlayerPrefs.GetFloat("masterVolparameter", masterVol.value);
        PlayerPrefs.GetFloat("musicVolparameter", musicValue.value);
        PlayerPrefs.GetFloat("efeitosVolparameter", efeitosValue.value);
    }
    public void MasterVolumChange()
    {
        mixer.SetFloat("masterVolparameter", masterVol.value);
        PlayerPrefs.SetFloat("masterVolparameter", masterVol.value);
        PlayerPrefs.Save();
    }

    public void MusicVolumChange()
    {
        mixer.SetFloat("musicVolparameter", musicValue.value);
        PlayerPrefs.SetFloat("musicVolparameter", musicValue.value);
    }
    public void EfeitosVolumChange()
    {
        mixer.SetFloat("efeitosVolparameter", efeitosValue.value);
        PlayerPrefs.SetFloat("efeitosVolparameter", efeitosValue.value);
    }
}

