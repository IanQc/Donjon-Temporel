using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlateMaterialManager : MonoBehaviour
{
    [SerializeField] private Material originalMaterial; 
    [SerializeField] private Material rightMaterial;    
    [SerializeField] private Material wrongMaterial;  
    [SerializeField] private Transform resetPositionTransform;
      

    public Material OriginalMaterial => originalMaterial;
    public Material RightMaterial => rightMaterial;
    public Material WrongMaterial => wrongMaterial;


    public void ResetPosition()
    {
        if (resetPositionTransform != null)
        {
            transform.position = resetPositionTransform.position;
        }
        else
        {
            Debug.LogWarning("Position initial null.");
        }
    }
}




