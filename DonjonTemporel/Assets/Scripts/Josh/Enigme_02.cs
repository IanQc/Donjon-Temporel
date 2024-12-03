using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enigme_02 : MonoBehaviour
{
    [SerializeField] string tagRight; 
    [SerializeField] UnityEvent onTriggerEnterRight; 
    [SerializeField] UnityEvent onTriggerEnterWrong; 
    [SerializeField] UnityEvent onTriggerExitRight; 
    [SerializeField] UnityEvent onEnigmeComplete;

    private bool isSocketComplete = false; 

    public event Action<Enigme_02> OnSocketSuccess; 
    public event Action<Enigme_02> OnSocketFailed;  


    public void ResetEnigme02()
    {
        isSocketComplete = false;
        Debug.Log($"Enigme 02 a été reset");
    }

    void OnTriggerEnter(Collider other)
    {
        SlateMaterialManager materialManager = other.GetComponent<SlateMaterialManager>();

        if (other.tag == tagRight && !isSocketComplete)
        {
            isSocketComplete = true;
                if (materialManager != null)
                {
                    ApplyMaterial(other, materialManager.RightMaterial);
                }
            Debug.Log($"Socket Completé !");
            onEnigmeComplete.Invoke();
            OnSocketSuccess?.Invoke(this); 
            onTriggerEnterRight.Invoke();
        }
        else if (other.tag != tagRight)
        {
            if (materialManager != null)
            {
                ApplyMaterial(other, materialManager.WrongMaterial);
            }
            onTriggerEnterWrong.Invoke();
            Debug.Log("Mauvais Slate");
        }
    }

    void OnTriggerExit(Collider other)
    {
        SlateMaterialManager materialManager = other.GetComponent<SlateMaterialManager>();

        if (isSocketComplete)
        {
            isSocketComplete = false;
            if (materialManager != null)
            {
                ApplyMaterial(other, materialManager.OriginalMaterial);
            }
            onTriggerExitRight.Invoke();
            OnSocketFailed?.Invoke(this);
            Debug.Log($"Socket n'est plus completé");
        }
        else if (other.tag != tagRight)
        {
            if (materialManager != null)
            {
                ApplyMaterial(other, materialManager.OriginalMaterial);
            }
            Debug.Log("Slate enlevé.");
        }
    }

    void ApplyMaterial(Collider obj, Material material)
    {
        MeshRenderer renderer = obj.GetComponent<MeshRenderer>();
        if (renderer != null && material != null)
        {
            renderer.material = material;
        }
    }
}






