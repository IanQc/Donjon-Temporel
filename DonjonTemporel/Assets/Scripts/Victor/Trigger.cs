using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    [SerializeField] string tagFilter;

    [SerializeField] UnityEvent onTriggerEnter;

    [SerializeField] UnityEvent onTriggerExit;

    void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
        Debug.Log("enter");
    }

    void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
        Debug.Log("leave");
    }
}
