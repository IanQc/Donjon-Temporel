using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victorGileau_activateRoom : MonoBehaviour
{

    public GameObject present;
    public GameObject passe;
    public GameObject videoTransition;
    public GameObject videoTransitionCanvas;

    public void changerTemps() {
        if (present.activeSelf)
        {
            passe.SetActive(true);
            present.SetActive(false);
            StartCoroutine(attendreUneSeconde());
        } else
        {
            passe.SetActive(false);
            present.SetActive(true);
            StartCoroutine(attendreUneSeconde());
        }
    }

    IEnumerator attendreUneSeconde()
    {
        videoTransition.SetActive(true);
        videoTransitionCanvas.SetActive(true);
        yield return new WaitForSeconds(1f);
        videoTransition.SetActive(false);
        videoTransitionCanvas.SetActive(false);
    }
}
