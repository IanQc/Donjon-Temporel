using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    private Scene currentScene;

    // Start is called before the first frame update
    void Start()
    {
        // Récupérer la scène active
        currentScene = SceneManager.GetActiveScene();
        Debug.Log("Current Scene: " + currentScene.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected with: " + other.name); // Afficher le nom de l'objet entrant

        // Vérifier si l'objet a le tag "Player"
        if (other.CompareTag("DetectP"))
        {
            Debug.Log("Tag is DetectP");

            // Vérifier si on est dans la bonne scène
            if (currentScene.name == "Niveau_Main")
            {
                Debug.Log("Scene is Niveau_Main, loading win scene...");
                SceneManager.LoadScene("win");
            }
            else
            {
                Debug.Log("Current scene is not Niveau_Main");
            }
        }
        else
        {
            Debug.Log("Tag is not DetectP");
        }
    }
}
