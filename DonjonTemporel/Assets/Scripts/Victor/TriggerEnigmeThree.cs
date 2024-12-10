using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triggedr : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string tagRight;

    [SerializeField] UnityEvent onTriggerEnter;

    [SerializeField] UnityEvent onTriggerEnterRight;

    [SerializeField] UnityEvent onTriggerEnterWrong;

    [SerializeField] UnityEvent onTriggerExit;

    [SerializeField] UnityEvent onTriggerExitWrong;

    [SerializeField] UnityEvent onTriggerStay;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagRight)
        {
            onTriggerEnterRight.Invoke();
            Debug.Log("enter le bon");
        } else if (other.tag == "DetectP" || other.tag == "main") 
        {
            Debug.Log("player enter");
        } else
        {
            onTriggerEnterWrong.Invoke();
            Debug.Log("enter le mauvais");
        }
        Debug.Log("enter");
    }

    /*

    void OnTriggerStay(Collider other)
    {
        if (other.tag == tagRight)
        {
            onTriggerEnterRight.Invoke();
            Debug.Log("contien le bon");
        } else
        {
            onTriggerEnterWrong.Invoke();
            Debug.Log("contien le mauvais");
        }
        onTriggerStay.Invoke();
        Debug.Log("reste");
    }
    */
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("player leave");
        } else
        {
            if (other.tag == tagRight)
            {
                onTriggerExit.Invoke();
                Debug.Log("leave right");
            } else
            {
                onTriggerExitWrong.Invoke();
                Debug.Log("leave wrong");
            }
            
            
        }
        
    }
}
