using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeedleEngeleCarpisiLeft : MonoBehaviour
{
    public int kalanNeedleLeft;

    public Collider leftEngelCollider;

    public MeshRenderer leftEngelMeshRenderer;

    public float engelKalisSuresi;

    public Text kalanNeedleLeftText;

    public int leftNeedleBitisKontrolcusu;

    public AudioSource soundLeft;

    // Start is called before the first frame update
    void Start()
    {
        leftEngelMeshRenderer = GetComponent<MeshRenderer>();
        leftEngelCollider = GetComponent<Collider>();

        kalanNeedleLeftText.text = "" + kalanNeedleLeft;

        engelKalisSuresi = 1.5f;

        leftEngelMeshRenderer.enabled = false;
        leftEngelCollider.enabled = false;

        PlayerPrefs.GetInt("soundVolume");
    }

    // Update is called once per frame
    void Update()
    {
        kalanNeedleLeftText.text = "" + kalanNeedleLeft;

        if(engelKalisSuresi > 0f && leftEngelMeshRenderer.enabled == true && leftEngelCollider.enabled == true)
        {
            engelKalisSuresi -= Time.deltaTime;
        }
        else if(engelKalisSuresi <= 0f && leftEngelMeshRenderer.enabled == true && leftEngelCollider.enabled == true)
        {
            leftEngelMeshRenderer.enabled = false;
            leftEngelCollider.enabled = false;
            engelKalisSuresi = 1.5f;
        }
    }

    private void LateUpdate()
    {
        if (kalanNeedleLeft <= 0)
        {
            PlayerPrefs.SetInt("leftNeedleBitisKontrolcusu", 1);
        }
    }

    public void leftEngelAc()
    {
        leftEngelMeshRenderer.enabled = true;
        leftEngelCollider.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1") || other.CompareTag("Needle2") || other.CompareTag("Needle3") || other.CompareTag("Needle4") || other.CompareTag("Needle5"))
        {
            Destroy(other.gameObject);
            kalanNeedleLeft--;
            engelKalisSuresi = 1.5f;
            if (PlayerPrefs.GetInt("soundVolume") == 1)
            {
                soundLeft.Play();
            }
            leftEngelMeshRenderer.enabled = false;
            leftEngelCollider.enabled = false;
        }
    }
}
