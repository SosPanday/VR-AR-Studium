using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<AudioSource>().Play();
    }
}
