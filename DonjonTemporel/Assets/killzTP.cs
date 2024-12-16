using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    public Transform teleportDestination; // La destination où le joueur sera téléporté

    private void OnTriggerEnter(Collider other)
    {
        // Vérifier si l'objet entrant est le joueur
        if (other.CompareTag("DetectP"))
        {
            // Déplacer le joueur à la destination de téléportation
            other.transform.position = teleportDestination.position;
            // Optionnel : Réinitialiser la rotation du joueur
            other.transform.rotation = teleportDestination.rotation;
        }
    }
}
