using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject videoIndiceIn;
    public GameObject videoIndiceTalk;
    public GameObject videoIndiceOut;
    public GameObject canvaIndiceIn;
    public GameObject canvaIndiceTalk;
    public GameObject canvaIndiceOut;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "IndicesTest")
        {
            Debug.Log("enter collider");

            videoIndiceIn.SetActive(true);
            canvaIndiceIn.SetActive(true);
            

            StartCoroutine(timerUnSec());

            videoIndiceIn.SetActive(false);
            canvaIndiceIn.SetActive(false);

            videoIndiceTalk.SetActive(true);
            canvaIndiceTalk.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "IndicesTest")
        {
            Debug.Log("exit collider");

            videoIndiceTalk.SetActive(false);
            canvaIndiceTalk.SetActive(false);

            videoIndiceOut.SetActive(true);
            canvaIndiceOut.SetActive(true);

            StartCoroutine(timerUnSec());

            videoIndiceOut.SetActive(false);
            canvaIndiceOut.SetActive(false);
        }
        
    }

    IEnumerator timerUnSec()
    {
        yield return new WaitForSeconds(1f);
    }

}
