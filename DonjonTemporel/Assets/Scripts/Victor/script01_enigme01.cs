using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class script01_enigme01 : MonoBehaviour
{
    public int arrayLenght = 4;
    
    private int clickedOne = 1;
    private int clickedTwo = 2;
    private int clickedThree = 3;
    private int clickedfour = 4;
    
    private int totalPressed = 0;

    //public GameObject btnClickedCurrent;
    /*
    public GameObject btnClickedOne;
    public GameObject btnClickedTwo;
    public GameObject btnClickedThree;
    public GameObject btnClickedFour;
    */
    [SerializeField] UnityEvent Win;

    [SerializeField] UnityEvent Lose;

    [SerializeField] UnityEvent ResetBtn;
    /*
    public void checkArray(int[] arraytest)
    {
    
    }
    */

    public void addTotalButtonPressed()
    {
        totalPressed++;
    }

    public void setTotalButtonPressedToZero()
    {
        totalPressed = 0;
        ResetBtn.Invoke();
    }

    private void clearArray(int[] array)
    {
        for (int i = 0; i < 4; i++)
        {
            array[i] = 0;
        }
    }

    public void ButtonPressed(GameObject btnClickedCurrent)
    {
        int[] arrayOne = new int[] { 4, 2, 1, 3 };
        int[] arrayEntered = new int[4];


        Debug.Log("test number of click = " + btnClickedCurrent);
        Debug.Log("tag btn cliked = " + btnClickedCurrent.gameObject.tag);

        switch (totalPressed)
        {
            case 0:
                if (btnClickedCurrent.gameObject.tag == "btn0" + arrayOne[0])
                {
                    Debug.Log("1e est bon " + arrayOne[0]);
                    arrayEntered[0] = clickedfour;
                    addTotalButtonPressed();
                } else
                {
                    totalPressed = 0;
                    clearArray(arrayEntered);
                    Debug.Log("total clicked restet to 0");
                    Lose.Invoke();
                }
                break;
            case 1:
                if (btnClickedCurrent.gameObject.tag == "btn0" + arrayOne[1])
                {
                    Debug.Log("2e est bon " + arrayOne[1]);
                    arrayEntered[1] = clickedTwo;
                    addTotalButtonPressed();
                }
                else
                {
                    totalPressed = 0;
                    clearArray(arrayEntered);
                    Debug.Log("total clicked restet to 0");
                    Lose.Invoke();
                }
                break;
            case 2:
                if (btnClickedCurrent.gameObject.tag == "btn0" + arrayOne[2])
                {
                    Debug.Log("3e est bon " + arrayOne[2]);
                    arrayEntered[2] = clickedOne;
                    addTotalButtonPressed();
                }
                else
                {
                    totalPressed = 0;
                    clearArray(arrayEntered);
                    Debug.Log("total clicked restet to 0");
                    Lose.Invoke();
                }
                break;
            case 3:
                if (btnClickedCurrent.gameObject.tag == "btn0" + arrayOne[3])
                {
                    Debug.Log("4e est bon " + arrayOne[3]);
                    arrayEntered[3] = clickedThree;
                    addTotalButtonPressed();
                    Win.Invoke();
                }
                else
                {
                    totalPressed = 0;
                    clearArray(arrayEntered);
                    Debug.Log("total clicked restet to 0");
                    Lose.Invoke();
                }
                break;
        }

    }
}
