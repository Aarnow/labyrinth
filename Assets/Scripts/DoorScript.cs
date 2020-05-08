using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "Player")
        {
            Debug.Log(other.name + " inside trigger");
        }
    }

    private void OnTriggerExit(Collider other)
    {

    }
}
