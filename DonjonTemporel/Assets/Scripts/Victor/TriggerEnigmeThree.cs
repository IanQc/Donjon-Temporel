using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triggedr : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string tagFilter;

    [SerializeField] string tagRight;

    [SerializeField] UnityEvent onTriggerEnter;

    [SerializeField] UnityEvent onTriggerEnterRight;

    [SerializeField] UnityEvent onTriggerEnterWrong;

    [SerializeField] UnityEvent onTriggerExit;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagRight)
        {
            onTriggerEnterRight.Invoke();
            Debug.Log("enter le bon");
        } else
        {
            onTriggerEnterWrong.Invoke();
            Debug.Log("enter le mauvais");
        }
        onTriggerEnter.Invoke();
        Debug.Log("enter");
    }

    void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
        Debug.Log("leave");
    }
}
