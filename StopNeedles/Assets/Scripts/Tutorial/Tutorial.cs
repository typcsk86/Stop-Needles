using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text tutorialText;
    public Image butonColor;
    //public Button butonRenkDegisim;
    //public ColorBlock buttonColor;

    // Start is called before the first frame update
    void Start()
    {
        butonColor = butonColor.GetComponent<Image>();

        tutorialText = tutorialText.GetComponent<Text>();

        tutorialText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1"))
        {
            butonColor.color = new Color(255,90,90);
            //butonRenkDegisim.colors = buttonColor;
            tutorialText.gameObject.SetActive(true);


            Time.timeScale = 0;
        }
    }

    public void timeScaleDuzeltici()
    {
        Time.timeScale = 1;
        tutorialText.gameObject.SetActive(false);
    }
}
