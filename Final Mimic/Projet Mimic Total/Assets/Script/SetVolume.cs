using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer NewAudioMixer;
    public void SetLevel (float sliderValue)
    {
        NewAudioMixer.SetFloat ("Volume",Mathf.Log10 (sliderValue)*20); 
    }
}
