using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class Son : MonoBehaviour
{
    public AudioSource music1; // Musique 1
    public AudioSource music2; // Musique 2
    public AudioSource music3; // Musique 3
    public AudioSource music4; // Musique 3
    public float fadeDuration = 2f; // Durée du fade in/out en secondes

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zone_activation_01"))
        {
            StartCoroutine(FadeInMusic(music1, fadeDuration));
        }
        else if (other.CompareTag("Zone_activation_02"))
        {
            StartCoroutine(FadeInMusic(music2, fadeDuration));
        }
        else if (other.CompareTag("Zone_activation_03"))
        {
            StartCoroutine(FadeInMusic(music3, fadeDuration));
        }
        else if (other.CompareTag("Zone_activation_04"))
        {
            StartCoroutine(FadeInMusic(music4, fadeDuration));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Zone_activation_01"))
        {
            StartCoroutine(FadeOutMusic(music1, fadeDuration));
        }
        else if (other.CompareTag("Zone_activation_02"))
        {
            StartCoroutine(FadeOutMusic(music2, fadeDuration));
        }
        else if (other.CompareTag("Zone_activation_03"))
        {
            StartCoroutine(FadeOutMusic(music3, fadeDuration));
        }
        else if (other.CompareTag("Zone_activation_04"))
        {
            StartCoroutine(FadeOutMusic(music4, fadeDuration));
        }
    }

    private IEnumerator FadeInMusic(AudioSource audioSource, float duration)
    {   
        if (!audioSource.isPlaying)
            audioSource.enabled = true;
            audioSource.Play();

        audioSource.volume = 0f;
        float startVolume = 0f;
        float targetVolume = 1f;

        for (float t = 0; t < duration; t += Time.deltaTime)
        {
            audioSource.volume = Mathf.Lerp(startVolume, targetVolume, t / duration);
            yield return null;
        }

        audioSource.volume = targetVolume;
    }

    private IEnumerator FadeOutMusic(AudioSource audioSource, float duration)
    {
        float startVolume = audioSource.volume;

        for (float t = 0; t < duration; t += Time.deltaTime)
        {
            audioSource.volume = Mathf.Lerp(startVolume, 0f, t / duration);
            yield return null;
        }

        audioSource.volume = 0f;
        audioSource.Stop();
        audioSource.enabled = false;
    }
}