using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelGoruntuleyici : MonoBehaviour
{
    public GameObject veryEasyLevelPanel;
    public GameObject easyLevelPanel;
    public GameObject mediumLevelPanel;
    public GameObject hardLevelPanel;
    public GameObject veryHardLevelPanel;
    public GameObject bonusLevelPanel;

    // Start is called before the first frame update
    void Start()
    {
        veryEasyLevelPanel.gameObject.SetActive(true);
        easyLevelPanel.gameObject.SetActive(false);
        mediumLevelPanel.gameObject.SetActive(false);
        hardLevelPanel.gameObject.SetActive(false);
        veryHardLevelPanel.gameObject.SetActive(false);
        bonusLevelPanel.gameObject.SetActive(false);
    }

    public void veryEasyLevelAcan()
    {
        veryEasyLevelPanel.gameObject.SetActive(true);
        easyLevelPanel.gameObject.SetActive(false);
        mediumLevelPanel.gameObject.SetActive(false);
        hardLevelPanel.gameObject.SetActive(false);
        veryHardLevelPanel.gameObject.SetActive(false);
        bonusLevelPanel.gameObject.SetActive(false);
    }

    public void easyLevelAcan()
    {
        veryEasyLevelPanel.gameObject.SetActive(false);
        easyLevelPanel.gameObject.SetActive(true);
        mediumLevelPanel.gameObject.SetActive(false);
        hardLevelPanel.gameObject.SetActive(false);
        veryHardLevelPanel.gameObject.SetActive(false);
        bonusLevelPanel.gameObject.SetActive(false);
    }

    public void mediumLevelAcan()
    {
        veryEasyLevelPanel.gameObject.SetActive(false);
        easyLevelPanel.gameObject.SetActive(false);
        mediumLevelPanel.gameObject.SetActive(true);
        hardLevelPanel.gameObject.SetActive(false);
        veryHardLevelPanel.gameObject.SetActive(false);
        bonusLevelPanel.gameObject.SetActive(false);
    }

    public void hardLevelAcan()
    {
        veryEasyLevelPanel.gameObject.SetActive(false);
        easyLevelPanel.gameObject.SetActive(false);
        mediumLevelPanel.gameObject.SetActive(false);
        hardLevelPanel.gameObject.SetActive(true);
        veryHardLevelPanel.gameObject.SetActive(false);
        bonusLevelPanel.gameObject.SetActive(false);
    }

    public void veryHardLevelAcan()
    {
        veryEasyLevelPanel.gameObject.SetActive(false);
        easyLevelPanel.gameObject.SetActive(false);
        mediumLevelPanel.gameObject.SetActive(false);
        hardLevelPanel.gameObject.SetActive(false);
        veryHardLevelPanel.gameObject.SetActive(true);
        bonusLevelPanel.gameObject.SetActive(false);
    }
    public void bonusLevelAcan()
    {
        veryEasyLevelPanel.gameObject.SetActive(false);
        easyLevelPanel.gameObject.SetActive(false);
        mediumLevelPanel.gameObject.SetActive(false);
        hardLevelPanel.gameObject.SetActive(false);
        veryHardLevelPanel.gameObject.SetActive(false);
        bonusLevelPanel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
