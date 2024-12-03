using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascenseur : MonoBehaviour
{
    public Animator animPlateforme;
    public GameObject joueur;
    public GameObject plateforme;
    public GameObject empty;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ascenseur")
        {
            joueur.transform.parent = plateforme.transform;
            animPlateforme.Play("ascenseur_animation_file");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ascenseur")
        {
            joueur.transform.parent = empty.transform;
        }
    }
}
