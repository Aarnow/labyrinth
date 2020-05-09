using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool CanOpen = false;
    [SerializeField]
    AudioClip soundOpen, soundDenied; //Create variable that stores different sounds

    [SerializeField]
    Animator myAnimator;

    [SerializeField]
    GameObject endPoint;

    private AudioSource myAudioSource;

    private void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {   
        if(other.tag == "Player" && CanOpen)
        {
            myAnimator.enabled = true;
            endPoint.SetActive(true);
            myAudioSource.PlayOneShot(soundOpen);
        }
        else
        {
            myAudioSource.PlayOneShot(soundDenied);
        }
    }
}
