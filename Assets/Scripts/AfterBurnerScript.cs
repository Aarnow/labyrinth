using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterBurnerScript : MonoBehaviour
{
    [SerializeField]
    int LevelToLoad;

    [SerializeField]
    bool autoIndex = true;

    private void Start()
    {
        if (autoIndex)
        {
            LevelToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            PlayerPrefs.SetInt("LevelToLoad", LevelToLoad);
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
