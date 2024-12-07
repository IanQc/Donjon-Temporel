using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//code pour le slider https://www.youtube.com/watch?v=yWCHaTwVblk
//code du fade in entre zones https://www.youtube.com/watch?v=1VXeyeLthdQ

//code test
public class soundManager : MonoBehaviour
{

    //AUDIO SOURCE KENZ
    public AudioSource audioPlayer;
    // Start is called before the first frame update
    //serialize du slider
    [SerializeField] Slider volumeSlider;

    //instances du fade
    /*public AudioClip defaultAmbiance;
    private AudioSource track01, track02;
    private bool isPlayingTrack01;

    public static soundManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }*/

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

        //fade

        /*track01 = gameObject.AddComponent<AudioSource>();
        track02 = gameObject.AddComponent<AudioSource>();
        isPlayingTrack01 = true;

        SwapTrack(defaultAmbiance);*/

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "zone_music_1")
        {
            audioPlayer.Play();
        }
    }



    /*public void SwapTrack(AudioClip newClip)
    {
        if (isPlayingTrack01)
        {
            track02.clip = newClip;
            track02.Play();
            track01.Stop();
        }
        else
        {
            track01.clip = newClip;
            track01.Play();
            track02.Stop();

            isPlayingTrack01 = !isPlayingTrack01;
        }
    }*/

    /*public void ReturnToDefault()
    {
        SwapTrack(defaultAmbiance);
    }*/

    //slider
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
