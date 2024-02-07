using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager_1 : MonoBehaviour
{
    public static AudioSource BGM;
    public static AudioClip newTrack;
    public static AudioClip defaultTrack;

    public static void changeBGM(int number)
    {
        BGM.Stop();
        BGM.clip = AudioSwitch(number);
        BGM.Play();
    }

    public static AudioClip AudioSwitch(int number)
    {
        switch(number)
        {
            case (0):
                return defaultTrack;

            case (1):
                return newTrack;

            default:
                return defaultTrack;
        }
    }
}
