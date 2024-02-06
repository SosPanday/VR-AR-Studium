using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairTrigger : MonoBehaviour
{
    public GameObject previousStair;
    public GameObject triggerObject;

    private void Start()
    {
        Transform triggerTransform = transform.Find("Trigger");
        if (triggerTransform != null)
        {
            GameObject triggerObject = triggerTransform.gameObject;
            OnTriggerEnter(triggerObject.GetComponent<BoxCollider>());
        }
    }
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
