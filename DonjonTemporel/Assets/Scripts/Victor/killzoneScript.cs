using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class killzoneScript : MonoBehaviour
{

    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = new Vector3(0f,0f,0f);
            Debug.Log("player teleported");
        }
    }
}
