using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngelButonuKontroluLeft : MonoBehaviour
{
    public Button leftButton;

    public float butonAcikKalmaSuresi;


    // Start is called before the first frame update
    void Start()
    {
        leftButton = leftButton.GetComponent<Button>();
        leftButton.interactable = false;

        butonAcikKalmaSuresi = 250f;
    }

    // Update is called once per frame
    void Update()
    {
        if (butonAcikKalmaSuresi > 0)
        {
            butonAcikKalmaSuresi--;
        }
        else if (butonAcikKalmaSuresi <= 0)
        {
            leftButton.interactable = false;
            butonAcikKalmaSuresi = 250f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1") || other.CompareTag("Needle2") || other.CompareTag("Needle3") || other.CompareTag("Needle4") || other.CompareTag("Needle5"))
        {
            leftButton.interactable = true;
            butonAcikKalmaSuresi = 250f;
        }
    }
}
