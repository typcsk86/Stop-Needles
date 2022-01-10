using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngelButonuKontroluUp : MonoBehaviour
{
    public Button upButton;

    public float butonAcikKalmaSuresi;


    // Start is called before the first frame update
    void Start()
    {
        upButton = upButton.GetComponent<Button>();
        upButton.interactable = false;

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
            upButton.interactable = false;
            butonAcikKalmaSuresi = 250f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1") || other.CompareTag("Needle2") || other.CompareTag("Needle3") || other.CompareTag("Needle4") || other.CompareTag("Needle5"))
        {
            upButton.interactable = true;
            butonAcikKalmaSuresi = 250f;
        }
    }
}
