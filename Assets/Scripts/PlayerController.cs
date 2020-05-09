using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f, rot=160f, curSpeed;

    [SerializeField]
    GameObject ImgGameOver; 

    void FixedUpdate()
    {
        

        if (Input.GetKey(KeyCode.LeftShift))
        {
            curSpeed = speed * 2;
        }
        else
        {
            curSpeed = speed;
        }

        transform.Rotate(Vector3.up * rot * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));

        float goForward = Input.GetAxis("Vertical");
        if(goForward > 0)//Never back ! 
        {
            transform.Translate(Vector3.forward * curSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        }
    }

    public void GameOver()
    {
        ImgGameOver.SetActive(true);
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene("Menu");
    }
}
