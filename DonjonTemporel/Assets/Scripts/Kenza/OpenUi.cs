using System.Collections;
using System.Collections.Generic;
using UnityEditor.Presets;
using UnityEngine;

public class OpenUi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject openMenu;
    public GameObject openInstructions;

    public void OpenMyUI()
    {
        if (openInstructions.activeSelf)
        {
            openInstructions.SetActive(false);
        }
        else
        {
            openInstructions.SetActive(true);
        }
    }
}
