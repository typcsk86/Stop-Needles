using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialNeedleCreatingRight : MonoBehaviour
{
    public GameObject needle;

    public Transform needleOlusturmaNoktasi;

    public float needleHizi;

    private float needleSayaciLimit;

    public float needleSayaciLimitUstSinir;
    public float needleSayaciLimitAltSinir;

    private float needleSayaci;

    public int rightNeedleSayisi;

    // Start is called before the first frame update
    void Start()
    {
        needleSayaci = Random.Range(needleSayaciLimitAltSinir, needleSayaciLimitUstSinir);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Time.timeScale == 1)
        {
            if (rightNeedleSayisi > 0)
            {
                if (needleSayaci <= 0)
                {
                    needleOlustur();
                    needleSayaciLimit = Random.Range(needleSayaciLimitAltSinir, needleSayaciLimitUstSinir);
                    needleSayaci = needleSayaciLimit;

                    rightNeedleSayisi--;
                }
            }
            if (needleSayaci > 0)
            {
                needleSayaci -= Time.deltaTime;
            }
        }
    }

    void needleOlustur()
    {
        GameObject olusanNeedle1 = Instantiate(needle,
                                               needleOlusturmaNoktasi.position,
                                               needleOlusturmaNoktasi.rotation);

        Rigidbody olusanNeedleninRB1 = olusanNeedle1.GetComponent<Rigidbody>();

        olusanNeedleninRB1.velocity = olusanNeedle1.transform.forward * needleHizi * Time.deltaTime;
    }
}
