using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeedleEngeleCarpisiRightTop : MonoBehaviour
{
    public int kalanNeedleRightTop;

    public Collider rightTopEngelCollider;

    public MeshRenderer rightTopEngelMeshRenderer;

    public float engelKalisSuresi;

    public Text kalanNeedleRightTopText;

    public int rightTopNeedleBitisKontrolcusu;

    public AudioSource soundRightTop;

    // Start is called before the first frame update
    void Start()
    {
        rightTopEngelMeshRenderer = GetComponent<MeshRenderer>();
        rightTopEngelCollider = GetComponent<Collider>();

        kalanNeedleRightTopText.text = "" + kalanNeedleRightTop;

        engelKalisSuresi = 1.5f;

        rightTopEngelMeshRenderer.enabled = false;
        rightTopEngelCollider.enabled = false;

        PlayerPrefs.GetInt("soundVolume");
    }

    public void rightTopEngelAc()
    {
        rightTopEngelMeshRenderer.enabled = true;
        rightTopEngelCollider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        kalanNeedleRightTopText.text = "" + kalanNeedleRightTop;

        if (engelKalisSuresi > 0f && rightTopEngelMeshRenderer.enabled == true && rightTopEngelCollider.enabled == true)
        {
            engelKalisSuresi -= Time.deltaTime;
        }
        else if (engelKalisSuresi <= 0f && rightTopEngelMeshRenderer.enabled == true && rightTopEngelCollider.enabled == true)
        {
            rightTopEngelMeshRenderer.enabled = false;
            rightTopEngelCollider.enabled = false;
            engelKalisSuresi = 1.5f;
        }
    }

    void LateUpdate()
    {
        if (kalanNeedleRightTop <= 0)
        {
            PlayerPrefs.SetInt("rightTopNeedleBitisKontrolcusu", 1);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1") || other.CompareTag("Needle2") || other.CompareTag("Needle3") || other.CompareTag("Needle4") || other.CompareTag("Needle5"))
        {
            Destroy(other.gameObject);
            kalanNeedleRightTop--;
            engelKalisSuresi = 1.5f;
            if (PlayerPrefs.GetInt("soundVolume") == 1)
            {
                soundRightTop.Play();
            }
            rightTopEngelMeshRenderer.enabled = false;
            rightTopEngelCollider.enabled = false;
        }
    }
}
