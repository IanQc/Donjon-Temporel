using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManager_test02 : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource source;
    public string targetTag;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag(targetTag))
        {
            source.Play();
        }
    }
}
