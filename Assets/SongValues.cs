using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongValues : MonoBehaviour
{
    [Header("Initialization")]
    [SerializeField]  private AudioSource BGM;
    [SerializeField]  private AudioClip newTrack;
    [SerializeField]  private AudioClip defaultTrack;

    void Awake()
    {

        AudioManager_1.BGM = BGM;
        AudioManager_1.newTrack = newTrack;
        AudioManager_1.defaultTrack = defaultTrack;
    }
}
