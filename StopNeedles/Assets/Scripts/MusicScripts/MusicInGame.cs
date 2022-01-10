using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInGame : MonoBehaviour
{
    public AudioSource oyunMusic;

    // Start is called before the first frame update

    void Awake()
    {
        PlayerPrefs.GetInt("musicVolume");
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("musicVolume") == 0)
        {
            oyunMusic.Stop();
        }
        else if (PlayerPrefs.GetInt("musicVolume") == 1)
        {
            oyunMusic.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
