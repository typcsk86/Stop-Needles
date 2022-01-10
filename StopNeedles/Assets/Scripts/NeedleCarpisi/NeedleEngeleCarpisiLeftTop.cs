using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeedleEngeleCarpisiLeftTop : MonoBehaviour
{
    public int kalanNeedleLeftTop;

    public Collider leftTopEngelCollider;

    public MeshRenderer leftTopEngelMeshRenderer;

    public float engelKalisSuresi;

    public Text kalanNeedleLeftTopText;

    public int leftTopNeedleBitisKontrolcusu;

    public AudioSource soundLeftTop;

    // Start is called before the first frame update
    void Start()
    {
        leftTopEngelMeshRenderer = GetComponent<MeshRenderer>();
        leftTopEngelCollider = GetComponent<Collider>();

        kalanNeedleLeftTopText.text = "" + kalanNeedleLeftTop;

        engelKalisSuresi = 1.5f;

        leftTopEngelMeshRenderer.enabled = false;
        leftTopEngelCollider.enabled = false;

        PlayerPrefs.GetInt("soundVolume");
    }

    // Update is called once per frame
    void Update()
    {
        kalanNeedleLeftTopText.text = "" + kalanNeedleLeftTop;

        if (engelKalisSuresi > 0f && leftTopEngelMeshRenderer.enabled == true && leftTopEngelCollider.enabled == true)
        {
            engelKalisSuresi -= Time.deltaTime;
        }
        else if (engelKalisSuresi <= 0f && leftTopEngelMeshRenderer.enabled == true && leftTopEngelCollider.enabled == true)
        {
            leftTopEngelMeshRenderer.enabled = false;
            leftTopEngelCollider.enabled = false;
            engelKalisSuresi = 1.5f;
        }
    }

    void LateUpdate()
    {
        if (kalanNeedleLeftTop <= 0)
        {
            PlayerPrefs.SetInt("leftTopNeedleBitisKontrolcusu", 1);
        }
    }

    public void leftTopEngelAc()
    {
        leftTopEngelMeshRenderer.enabled = true;
        leftTopEngelCollider.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1") || other.CompareTag("Needle2") || other.CompareTag("Needle3") || other.CompareTag("Needle4") || other.CompareTag("Needle5"))
        {
            Destroy(other.gameObject);
            kalanNeedleLeftTop--;
            engelKalisSuresi = 1.5f;
            if (PlayerPrefs.GetInt("soundVolume") == 1)
            {
                soundLeftTop.Play();
            }
            leftTopEngelMeshRenderer.enabled = false;
            leftTopEngelCollider.enabled = false;
        }
    }
}
