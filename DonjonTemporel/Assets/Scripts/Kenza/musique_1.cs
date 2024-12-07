using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musique_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "zone_music_1" && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
