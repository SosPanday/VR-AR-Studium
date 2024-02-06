using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTrigger : MonoBehaviour
{
    public GameObject previousStair;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("We reached a trigger");
        // Check for player
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER TRIGGEREEED");
            // Destroy the previous stair
            Destroy(previousStair);

            // Play sound effect

            // Play particle effect
        }
    }
}
