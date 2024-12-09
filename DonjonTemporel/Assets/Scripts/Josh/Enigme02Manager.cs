using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enigme02Manager : MonoBehaviour
{
    [SerializeField] private List<Enigme_02> sockets; 
    [SerializeField] UnityEvent onEnigmeComplete;    

    private int completedSockets = 0;

    void Start()
    {
        foreach (Enigme_02 socket in sockets)
        {
            if (socket != null)
            {
                socket.OnSocketSuccess += OnSocketCompleted;
                socket.OnSocketFailed += OnSocketFailed;
                Debug.Log($"Connecté au socket: {socket.name}");
            }
            else
            {
                Debug.LogWarning("Socket est null.");
            }
        }
    }


    private void OnSocketCompleted(Enigme_02 socket)
    {
        completedSockets++;
        Debug.Log($"Slate completé. Total Completer: {completedSockets}/{sockets.Count}");

        if (completedSockets == sockets.Count)
        {
            Debug.Log("Enigme 02 completé");
            onEnigmeComplete.Invoke();
        }
    }

    private void OnSocketFailed(Enigme_02 socket)
    {
        completedSockets--;
        Debug.Log($"Slate enlevé. Total: {completedSockets}/{sockets.Count}");
    }

    public void ResetEnigmeManager02()
    {
        completedSockets = 0;

        foreach (Enigme_02 socket in sockets)
        {
            socket.ResetEnigme02();
        }

        Debug.Log("Enigme 02 a été reset.");
    }
}


