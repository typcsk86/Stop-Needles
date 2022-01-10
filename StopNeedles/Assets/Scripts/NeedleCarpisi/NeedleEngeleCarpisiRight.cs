using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeedleEngeleCarpisiRight : MonoBehaviour
{
    public int kalanNeedleRight;

    public Collider rightEngelCollider;

    public MeshRenderer rightEngelMeshRenderer;

    public float engelKalisSuresi;

    public Text kalanNeedleRightText;

    public int rightNeedleBitisKontrolcusu;

    public AudioSource soundRight;

    // Start is called before the first frame update
    void Start()
    {
        rightEngelMeshRenderer = GetComponent<MeshRenderer>();
        rightEngelCollider = GetComponent<Collider>();

        kalanNeedleRightText.text = "" + kalanNeedleRight;

        engelKalisSuresi = 1.5f;

        rightEngelMeshRenderer.enabled = false;
        rightEngelCollider.enabled = false;

        PlayerPrefs.GetInt("soundVolume");

    }

    // Update is called once per frame
    void Update()
    {
        kalanNeedleRightText.text = "" + kalanNeedleRight;

        if (engelKalisSuresi > 0f && rightEngelMeshRenderer.enabled == true && rightEngelCollider.enabled == true)
        {
            engelKalisSuresi -= Time.deltaTime;
        }
        else if (engelKalisSuresi <= 0f && rightEngelMeshRenderer.enabled == true && rightEngelCollider.enabled == true)
        {
            rightEngelMeshRenderer.enabled = false;
            rightEngelCollider.enabled = false;
            engelKalisSuresi = 1.5f;
        }
    }

    void LateUpdate()
    {
        if (kalanNeedleRight <= 0)
        {
            PlayerPrefs.SetInt("rightNeedleBitisKontrolcusu", 1);
        }
    }

    public void rightEngelAc()
    {
        rightEngelMeshRenderer.enabled = true;
        rightEngelCollider.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1") || other.CompareTag("Needle2") || other.CompareTag("Needle3") || other.CompareTag("Needle4") || other.CompareTag("Needle5"))
        {
            Destroy(other.gameObject);
            kalanNeedleRight--;
            engelKalisSuresi = 1.5f;
            if (PlayerPrefs.GetInt("soundVolume") == 1)
            {
                soundRight.Play();
            }
            rightEngelMeshRenderer.enabled = false;
            rightEngelCollider.enabled = false;
        }
    }
}
