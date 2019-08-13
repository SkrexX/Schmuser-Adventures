using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioClip soundClip;
    public AudioSource soundSource;
    void Start()
    {
        soundSource.clip = soundClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
