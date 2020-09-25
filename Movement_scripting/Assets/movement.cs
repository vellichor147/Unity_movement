using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //public Rigidbody player;
    public float speed = 10;
    Vector3 forwardVector;

    // MOVE CUBE BY 1 UNIT
    // Input.GetKeyDown = one key press moves cube by one unit
    // transform.Translate = collision causes bug (two objects can't be at the same place at the same time)
    void moveGetKeyDown()
    {
        if (Input.GetKeyDown("up"))
        {
            transform.Translate(0.0f, 0.0f, 1.0f);
        }
        if (Input.GetKeyDown("down"))
        {
            transform.Translate(0.0f, 0.0f, -1.0f);
        }
        if (Input.GetKeyDown("left"))
        {
            transform.Translate(-1.0f, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown("right"))
        {
            transform.Translate(1.0f, 0.0f, 0.0f);
        }
    }

    // Input.GetKey = cube moves by 1 unit while key is pressed
    // transform.Translate = collision causes bug (two objects can't be at the same place at the same time)
    // smooth effect = accomplished by using smaller value of position change
    void moveGetKey()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(0.0f, 0.0f, 0.005f);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0.0f, 0.0f, -0.005f);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-0.005f, 0.0f, 0.0f);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(0.005f, 0.0f, 0.0f);
        }
    }


    void Start()
    {
        
    }

    void Update()
    {
        //moveGetKeyDown();
        moveGetKey();
        
        //Debug.Log(transform.position);
        //forwardVector = new Vector3(0f, 0f, 1f);
        //transform.position += forwardVector * speed * Time.deltaTime;
    }
}
