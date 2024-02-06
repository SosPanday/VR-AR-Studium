using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTrigger : MonoBehaviour
{
    public GameObject previousStair;

    private void OnTriggerEnter(Collider other)
    {
        // Check for player
        if (other.CompareTag("Player"))
        {
            // Destroy the previous stair
            Destroy(previousStair);

            // Play sound effect

            // Play particle effect
        }
    }
}
