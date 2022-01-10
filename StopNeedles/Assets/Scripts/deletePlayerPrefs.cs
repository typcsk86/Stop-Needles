using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletePlayerPrefs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deleteKeys()
    {
        PlayerPrefs.DeleteKey("saveIndex");
    }

    public void levelleriAc()
    {
        PlayerPrefs.SetInt("saveIndex", 120);
    }

    public void level100Ac()
    {
        PlayerPrefs.SetInt("saveIndex", 100);
    }

    public void level80Ac()
    {
        PlayerPrefs.SetInt("saveIndex", 80);
    }

    public void level65Ac()
    {
        PlayerPrefs.SetInt("saveIndex", 65);
    }
}
