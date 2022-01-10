using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeedleEngeleCarpisiUp : MonoBehaviour
{
    public int kalanNeedleUp;

    public Collider upEngelCollider;

    public MeshRenderer upEngelMeshRenderer;

    public float engelKalisSuresi;

    public Text kalanNeedleUpText;

    public int upNeedleBitisKontrolcusu;

    public AudioSource soundUp;

    // Start is called before the first frame update
    void Start()
    {
        upEngelMeshRenderer = GetComponent<MeshRenderer>();
        upEngelCollider = GetComponent<Collider>();

        kalanNeedleUpText.text = "" + kalanNeedleUp;

        engelKalisSuresi = 1.5f;

        upEngelMeshRenderer.enabled = false;
        upEngelCollider.enabled = false;

        PlayerPrefs.GetInt("soundVolume");
    }

    // Update is called once per frame
    void Update()
    {
        kalanNeedleUpText.text = "" + kalanNeedleUp;

        if (engelKalisSuresi > 0f && upEngelMeshRenderer.enabled == true && upEngelCollider.enabled == true)
        {
            engelKalisSuresi -= Time.deltaTime;
        }
        else if (engelKalisSuresi <= 0f && upEngelMeshRenderer.enabled == true && upEngelCollider.enabled == true)
        {
            upEngelMeshRenderer.enabled = false;
            upEngelCollider.enabled = false;
            engelKalisSuresi = 1.5f;
        }
    }

    void LateUpdate()
    {
        if (kalanNeedleUp <= 0)
        {
            PlayerPrefs.SetInt("upNeedleBitisKontrolcusu", 1);
        }
    }

    public void upEngelAc()
    {
        upEngelMeshRenderer.enabled = true;
        upEngelCollider.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1") || other.CompareTag("Needle2") || other.CompareTag("Needle3") || other.CompareTag("Needle4") || other.CompareTag("Needle5"))
        {
            Destroy(other.gameObject);
            kalanNeedleUp--;
            engelKalisSuresi = 1.5f;
            if (PlayerPrefs.GetInt("soundVolume") == 1)
            {
                soundUp.Play();
            }
            upEngelMeshRenderer.enabled = false;
            upEngelCollider.enabled = false;
        }
    }
}
