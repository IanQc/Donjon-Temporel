using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class check_all_enigme : MonoBehaviour
{
    [SerializeField] UnityEvent SuccesAll;

    private int total = 0;

    public int maxTotal = 3;

    public void addToTotal()
    {
        total++;
    }

    public void removeFromTotal()
    {
        total--;
    }

    private void checkTotal()
    {
        if (total == maxTotal)
        {
            SuccesAll.Invoke();
            Debug.Log("Reussi tout les enigmes");
        } else
        {
            Debug.Log("N'a pas reussi tout les enigmes encores");
        }
    }

}
