using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//code pour le slider https://www.youtube.com/watch?v=yWCHaTwVblk

//code test
public class soundManager : MonoBehaviour
{

    // Start is called before the first frame update
    //serialize du slider
    [SerializeField] Slider volumeSlider;



    void Start()
    {
        //volume
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }

        else
        {
            Load();
        }


    }

   

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }




}
