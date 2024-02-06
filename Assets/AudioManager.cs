using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class AudioManager : MonoBehaviour
{
    private Vector3 prevPosition;
    private int lastWalkSound = 0;
    void Start()
    {
        transform.GetComponents<AudioSource>()[0].Play();
        prevPosition = transform.position;
    }

    private void Update()
    {
        if((transform.position - prevPosition).magnitude > 0.7f)
        {
            prevPosition = transform.position;
            PlaySound();
        }
    }
    private void PlaySound()
    {
        lastWalkSound += (int)(UnityEngine.Random.value*2) + 1;
        lastWalkSound %= 3;
        transform.GetComponents<AudioSource>()[lastWalkSound + 1].Play();
    }
}
