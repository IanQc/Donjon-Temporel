using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
// Code crée par moi (Joshua) et assisté par ChatGPT (Pistes pour comment procédé, débogage, etc.)
public class Enigme_02 : MonoBehaviour
{
    [SerializeField] string tagRight; 
    [SerializeField] UnityEvent onTriggerEnterRight; 
    [SerializeField] UnityEvent onTriggerEnterWrong; 
    [SerializeField] UnityEvent onTriggerExitRight; 
    [SerializeField] UnityEvent onEnigmeComplete;

    private int slateCount = 0; 

    public event Action<Enigme_02> OnSocketSuccess; 
    public event Action<Enigme_02> OnSocketFailed;  


    public void ResetEnigme02()
    {
        Debug.Log($"Enigme 02 a été reset");
        slateCount = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        SlateMaterialManager materialManager = other.GetComponent<SlateMaterialManager>();

        if (other.tag == tagRight)
        {
            slateCount++;
            if (materialManager != null)
            {
                ApplyMaterial(other, materialManager.RightMaterial);
            }
            Debug.Log($"Bon Slate! Total: {slateCount}");
            onTriggerEnterRight.Invoke();

            if (slateCount == 1) 
            {
                onEnigmeComplete.Invoke();
                OnSocketSuccess?.Invoke(this);
            }
        }
        else
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

        if (other.tag == tagRight && slateCount > 0)
        {
            slateCount--;
            if (materialManager != null)
            {
                ApplyMaterial(other, materialManager.OriginalMaterial);
            }
            Debug.Log($"Bon Slate Enlevé. Total: {slateCount}");
            if (slateCount == 0)
            {
                onTriggerExitRight.Invoke();
                OnSocketFailed?.Invoke(this);
            }
        }
        else if (other.tag != tagRight)
        {
            if (materialManager != null)
            {
                ApplyMaterial(other, materialManager.OriginalMaterial);
            }
            Debug.Log("Mauvais Slate Enlevé");
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






