using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Music : MonoBehaviour
{
    public AudioClip newTrack;
    private AudioManager_1 am;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(newTrack != null)
             {
                am.changeBGM(newTrack);
             }   
        }
    }
}
