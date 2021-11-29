using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactTrigger : MonoBehaviour
{
    public GameObject artifactObj;
    // Start is called before the first frame update
    void Start()
    {
        artifactObj = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Artifact"))
        {
            artifactObj = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Artifact"))
        {
            artifactObj = null;
        }
    }
}
