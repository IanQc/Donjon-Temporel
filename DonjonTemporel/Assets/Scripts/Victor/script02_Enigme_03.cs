using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class script02_Enigme_03 : MonoBehaviour
{

    [SerializeField] UnityEvent totalCount;

    [SerializeField] UnityEvent notTotalCount;

    private int count = 0;
    public int countTotal = 0;

    public int allCount;

    public void addToCount()
    {
        if (count >= 0)
        {
            count++;
        }
        Debug.Log("count = " + count);
        checkCountDoEvent();
        Debug.Log("coun after check = " + count);
    }


    public void removeFromCount()
    {
        if (count > 0)
        {
            count = count - 1;
        }
        Debug.Log("count = " + count);
        checkCountDoEvent();
        Debug.Log("coun after check = " + count);
    }

    public void checkCountDoEvent()
    {
        Debug.Log("count = " + count);
        if (count == allCount)
        {
            totalCount.Invoke();
        }/* else if (countTotal < 0) {
            countTotal = 0;
        } */
        else
        {
            notTotalCount.Invoke();
        }
    }

}
