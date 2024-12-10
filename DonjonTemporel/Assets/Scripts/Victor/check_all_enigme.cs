using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class check_all_enigme : MonoBehaviour
{
    [SerializeField] UnityEvent SuccesAll;

    private int enigmeOne = 0;
    private int enigmeTwo = 0;
    private int enigmeThree = 0;

    public int maxTotal = 3;

    public void addToTotalOne()
    {
        if (enigmeOne == 0)
        {
            enigmeOne++;
        } else
        {
            enigmeOne = 1;
        }
        Debug.Log("Reussi enigme 1 : " + enigmeOne);
        checkTotal();
    }

    public void addToTotalTwo()
    {
        if (enigmeTwo == 0)
        {
            enigmeTwo++;
        } else
        {
            enigmeTwo = 1;
        }
        Debug.Log("Reussi enigme 2 : " + enigmeTwo);
        checkTotal();
    }

    public void addToTotalThree()
    {
        if (enigmeThree == 0)
        {
            enigmeThree++;
        } else
        {
            enigmeThree = 1;
        }
        Debug.Log("Reussi enigme 3 : " + enigmeThree);
        checkTotal();
    }
    /*
    public void removeFromTotal()
    {
        total--;
    }
    */
    private void checkTotal()
    {
        int total = enigmeThree + enigmeTwo + enigmeOne;
        if (total == maxTotal)
        {
            SuccesAll.Invoke();
            Debug.Log("Reussi tout les enigmes");
        } else
        {
            Debug.Log("N'a pas reussi tout les enigmes encores : " + total);
        }
    }

}
