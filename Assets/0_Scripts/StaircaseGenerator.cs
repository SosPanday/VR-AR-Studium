using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaircaseGenerator : MonoBehaviour
{
    public GameObject stairPrefab;
    public GameObject stairWood;
    public GameObject stairGlass;
    public StairType stairType;
    public int stairLength = 10;

    // Start is called before the first frame update
    void Start()
    {
        if(stairType == StairType.Wood)
        {
            stairPrefab = stairWood;
        } else if (stairType == StairType.Glass)
        {
            stairPrefab = stairGlass;
        }
        GenerateStairs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateStairs()
    {
        Vector3 currentPosition = transform.position;
        GameObject previousStair = null;

        for (int i = 0; i < stairLength; i++)
        {
            // Instantiate Stair
            GameObject stairInstance = Instantiate(stairPrefab, transform);

            // Add Scripts to Stair
            StairTrigger stairTrigger = stairInstance.GetComponentInChildren<StairTrigger>();

            if (stairTrigger != null)
                stairTrigger.previousStair = previousStair;

            previousStair = stairInstance;

            // Correct Position for Stairs
            currentPosition += Vector3.up * stairInstance.transform.localScale.y * 1.25f;
            currentPosition += Vector3.right * stairInstance.transform.localScale.x * 3.75f;

            stairInstance.transform.position += currentPosition;

        }
    }
}
