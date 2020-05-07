using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBasic : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f, curSpeed;
    private Vector3 movement = Vector3.zero; //Define Vector3 null (x,y,z --> 0,0,0)

    //Use method "update" for update every frame
    //for physical operation prefer FixedUpdate
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement = Vector3.back;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement = Vector3.zero;
            transform.Rotate(Vector3.up * -100 * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement = Vector3.zero;
            transform.Rotate(Vector3.up * 100 * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            curSpeed = speed * 2;
        }
        else
        {
            curSpeed = speed;
        }

        //Time.deltaTime/fixedDeltaTime --> standardize movement speed between different users
        transform.Translate(movement * curSpeed * Time.fixedDeltaTime);
        movement = Vector3.zero; //reset
    }
}
