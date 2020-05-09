using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnScript : MonoBehaviour
{
    [SerializeField]
    Transform myTarget;

    [SerializeField]
    SpikeScript spikeScript;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            spikeScript.target = myTarget;
        }
    }
}
