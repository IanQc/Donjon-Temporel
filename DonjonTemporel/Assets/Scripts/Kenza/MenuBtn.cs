using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuBtn : MonoBehaviour
{
    [SerializeField] private InputActionProperty menuButton;
    public InputActionProperty showButton;

    public GameObject menu;

    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
        }
    }


}
