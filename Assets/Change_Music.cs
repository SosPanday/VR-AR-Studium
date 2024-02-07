using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Music : MonoBehaviour
{
    public AudioClip newTrack;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(newTrack != null)
             {
                AudioManager_1.changeBGM(1);
             }   
        }
    }
}
