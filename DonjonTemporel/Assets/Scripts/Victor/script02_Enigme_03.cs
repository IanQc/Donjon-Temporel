using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class script02_Enigme_03 : MonoBehaviour
{

    [SerializeField] UnityEvent totalCount;

    [SerializeField] UnityEvent notTotalCount;

    public int count = 0;

    public void addToCount()
    {
        count++;
        Debug.Log("count = " + count);
        checkCountDoEvent();
        Debug.Log("coun after check = " + count);
    }

    public void removeFromCount()
    {
        count = count - 1;
        Debug.Log("count = " + count);
        checkCountDoEvent();
        Debug.Log("coun after check = " + count);
    }

    public void checkCountDoEvent()
    {
        Debug.Log("count = " + count);
        if (count == 2)
        {
            totalCount.Invoke();
        } else if (count < 0) {
            count = 0;
        } 
        else
        {
            notTotalCount.Invoke();
        }
    }

}
