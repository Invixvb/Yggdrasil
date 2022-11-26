using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;
 
    public Slider volume;

    public float VolumeValue;

    public void Start()
    {
        volume.value = PlayerPrefs.GetFloat("save", VolumeValue);
    }


    public void Setvolume(float volume)
    {
        VolumeValue = volume;
        PlayerPrefs.SetFloat("save", VolumeValue);

        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }
}
