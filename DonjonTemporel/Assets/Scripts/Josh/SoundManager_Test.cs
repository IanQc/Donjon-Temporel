using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager_Test : MonoBehaviour {
    private Coroutine currentCoroutine;
    public float fadeDuration = 1.0f;
    public AudioSource  Salle1Passe;
    public AudioSource  Salle1Present;
    public AudioSource GrotteSalle2;
    public AudioSource  Lave;
    public AudioSource  GrotteSalle3;
    public AudioSource  Salle3Present;
    public AudioSource Salle3Passe;

private void OnTriggerEnter(Collider other) {

    if (other.tag == "Start")
        {
            Debug.Log("START");
            StartCoroutine(FadeInSalle1Passe());
            StartCoroutine(FadeOutSalle1Present());
        }
    if (other.tag == "Present1") {
        Debug.Log("PRESENT");
        StartCoroutine(FadeOutSalle1Passe());
        StartCoroutine(FadeInSalle1Passe());
    }
}
IEnumerator FadeInSalle1Passe()
   {
        Salle1Passe.volume = 0;
        Salle1Passe.Play();
        
        float startVolume = Salle1Passe.volume;

        for (float t = 0; t <= fadeDuration; t += Time.deltaTime)
        {
            Salle1Passe.volume = Mathf.Lerp(startVolume, 1f, t / fadeDuration);
            yield return null;
        }
        Salle1Passe.volume = 1f;
    }

IEnumerator FadeInSalle1Present()
   {
        Salle1Present.volume = 0;
        Salle1Present.Play();
        
        float startVolume = Salle1Present.volume;

        for (float t = 0; t <= fadeDuration; t += Time.deltaTime)
        {
            Salle1Present.volume = Mathf.Lerp(startVolume, 1f, t / fadeDuration);
            yield return null;
        }
        Salle1Present.volume = 1f;
    }

IEnumerator FadeOutSalle1Present()
    {
        float targetVolume = Salle1Present.volume * 0.3f;
        float startVolume = Salle1Present.volume;

        for (float t = 0; t <= fadeDuration; t += Time.deltaTime)
        {
            Salle1Present.volume = Mathf.Lerp(startVolume, targetVolume, t / fadeDuration);
            yield return null;
        }
            Salle1Present.volume = targetVolume;
        }

IEnumerator FadeOutSalle1Passe()
    {
        float targetVolume =  Salle1Passe.volume * 0.3f;
        float startVolume =  Salle1Passe.volume;

        for (float t = 0; t <= fadeDuration; t += Time.deltaTime)
        {
             Salle1Passe.volume = Mathf.Lerp(startVolume, targetVolume, t / fadeDuration);
            yield return null;
        }
             Salle1Passe.volume = targetVolume;
        }

}





