using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UINeedleEngelAciciTrigger : MonoBehaviour
{
    public Collider engelCollider;

    public MeshRenderer engelMeshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Needle1") || other.CompareTag("Needle2") || other.CompareTag("Needle3") || other.CompareTag("Needle4") || other.CompareTag("Needle5"))
        {
            engelCollider.enabled = true;
            engelMeshRenderer.enabled = true;
        }
    }
}
