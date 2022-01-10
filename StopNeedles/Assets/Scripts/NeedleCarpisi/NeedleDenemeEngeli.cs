using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleDenemeEngeli : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1") || other.CompareTag("Needle2") || other.CompareTag("Needle3") || other.CompareTag("Needle4") || other.CompareTag("Needle4"))
        {
            Destroy(other.gameObject);
        }
    }
}
