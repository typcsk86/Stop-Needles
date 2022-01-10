using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelKilitScripts : MonoBehaviour
{
    public List<Button> levelButton1_20;

    private void Start()
    {
        int saveIndex = PlayerPrefs.GetInt("saveIndex");

        for (int i = 0; i < levelButton1_20.Count; i++)
        {
            if (i <= saveIndex)
            {
                levelButton1_20[i].interactable = true;
            }
            else
            {
                levelButton1_20[i].interactable = false;
            }
        }
    }
}
