using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victorGileau_activateRoom : MonoBehaviour
{

    public GameObject present;
    public GameObject passe;

    public void changerTemps() {
        if (present.activeSelf)
        {
            passe.SetActive(true);
            present.SetActive(false);
        } else
        {
            passe.SetActive(false);
            present.SetActive(true);
        }
    }
}
