using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class StaircaseGenerator : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject stairPrefab;
    public GameObject stairStone;
    public GameObject stairWood;
    public GameObject stairGlass;

    public GameObject finishPlatform;
    public StairType stairType;
    public int stairLength = 10;

    public static StairType stastairType = StairType.Glass;

    public static int stastairLength = 7;

    // Start is called before the first frame update
    void Start()
    {
            stairType = stastairType;
            stairLength = stastairLength;
        if(stairType == StairType.Wood)
        {
            stairPrefab = stairWood;
        } else if (stairType == StairType.Glass)
        {
            stairPrefab = stairGlass;
        } else
        {
            stairPrefab = stairStone;
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
