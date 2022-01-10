using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahnelerArasiGecis : MonoBehaviour
{
    public void open_Menu(string menu_name)
    {
        SceneManager.LoadScene(menu_name);
    }

    public void open_Level(string level_name)
    {
        SceneManager.LoadScene(level_name);
    }

    public void quitGame()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }
}
