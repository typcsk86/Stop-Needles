using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicDurdurmaButonu : MonoBehaviour
{
    public AudioSource musicAudio;
    public Button musicOnButton;
    public Button musicOffButton;

    public Button soundOnButton;
    public Button soundOffButton;

    public int musicVolume;
    public int soundVolume;

    void Awake()
    {
        PlayerPrefs.GetInt("musicVolume");
        PlayerPrefs.GetInt("soundVolume");
    }

    void Start()
    {
        musicAudio.volume = 1f;

        if(PlayerPrefs.GetInt("musicVolume") == 0)
        {
            musicOnButton.gameObject.SetActive(true);
            musicOffButton.gameObject.SetActive(false);
            musicAudio.Stop();
        }
        else if (PlayerPrefs.GetInt("musicVolume") == 1)
        {
            musicOnButton.gameObject.SetActive(false);
            musicOffButton.gameObject.SetActive(true);
            musicAudio.Play();
        }

        if(PlayerPrefs.GetInt("soundVolume") == 0)
        {
            soundOnButton.gameObject.SetActive(true);
            soundOffButton.gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("soundVolume") == 1)
        {
            soundOnButton.gameObject.SetActive(false);
            soundOffButton.gameObject.SetActive(true);
        }
    }

    public void musicOff()
    {
        musicOnButton.gameObject.SetActive(true);
        musicOffButton.gameObject.SetActive(false);
        musicAudio.Stop();
        PlayerPrefs.SetInt("musicVolume", 0);
    }

    public void musicOn()
    {
        musicOnButton.gameObject.SetActive(false);
        musicOffButton.gameObject.SetActive(true);
        musicAudio.Play();
        PlayerPrefs.SetInt("musicVolume", 1);
    }

    public void soundOff()
    {
        soundOnButton.gameObject.SetActive(true);
        soundOffButton.gameObject.SetActive(false);
        PlayerPrefs.SetInt("soundVolume", 0);
    }
    public void soundOn()
    {
        soundOnButton.gameObject.SetActive(false);
        soundOffButton.gameObject.SetActive(true);
        PlayerPrefs.SetInt("soundVolume", 1);
    }

}
