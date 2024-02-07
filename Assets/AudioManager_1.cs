using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager_1 : MonoBehaviour
{
    public AudioSource BGM;

    public void changeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }
}
