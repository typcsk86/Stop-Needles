using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UINeedleCreatingPoint : MonoBehaviour
{
    public GameObject needle;

    public Transform needleOlusturmaNoktasi;

    public float needleHizi;

    private int needleSayaci;

    private int needleSayisi;

    // Start is called before the first frame update
    void Start()
    {
        needleSayaci = Random.Range(100, 150);
        needleSayisi = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (needleSayisi > 0)
        {
            if (needleSayaci == 0)
            {
                needleOlustur();
                needleSayaci = Random.Range(300, 600);

                needleSayisi--;
            }
        }
        if (needleSayaci > 0)
        {
            needleSayaci--;
        }

        if (needleSayisi <= 0)
        {
            needleSayisi = 3;
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
