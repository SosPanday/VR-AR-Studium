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
        Vector3 glassSpawnPos = transform.position;
        if (previousStair != null)
        {
            glassSpawnPos = previousStair.transform.position;
        }
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

                // WORKS BUT AT THE PLAYERS FEET???? JUST NEED TO CHANGE POSITION MAYBE + (VECTOR3.LEFT *2)
                GameObject breakEffect = Instantiate(glassBrokenVFX, glassSpawnPos, Quaternion.identity, transform);
            }

            if(previousStair != null)
            {
                // Destroy the previous stair
                StartCoroutine(destroyer());
                Destroy(this);
            }
        }
    }

    IEnumerator destroyer()
    {
        Destroy(previousStair);
        yield return new WaitForSeconds(2);
    }
}
