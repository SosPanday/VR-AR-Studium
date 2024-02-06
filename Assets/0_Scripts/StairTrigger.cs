using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTrigger : MonoBehaviour
{
    public GameObject previousStair;
    public GameObject glassBrokenVFX;
    [Header("Sounds")]
    public AudioSource glassBrokenSFX;
    public AudioClip glassBrokenSound;
    [Range(0.1f, 1f)]
    public float volume = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        // Check for player
        if (other.CompareTag("Player"))
        {

            if(glassBrokenSFX != null)
            {
                // Play sound effect
                glassBrokenSFX.PlayOneShot(glassBrokenSound, volume);
            }
            
            if(glassBrokenSFX != null)
            {
                // Play particle effect
                GameObject breakEffect = Instantiate(glassBrokenVFX, transform.position, Quaternion.identity, transform);
            }

            // Destroy the previous stair
            Destroy(previousStair);

        }
    }
}
