using Boo.Lang;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    float force = 250;
    bool isJump = false;
    float jumpspeed = 25;
    private Rigidbody body;
    public static ball instance;
    public static ball Instance
    {
        get { if (instance == null) {
                instance = new ball();
            }
            return instance; }
    }
    void Start() { body = transform.GetComponent<Rigidbody>(); }

    void Update()
    {/*
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        new Vector3(moveHorizontal, 0.0f, moveVertical);
     */
       if(Input.GetKey(KeyCode.Space))
        {

            // body.AddForce(Vector3.up *300);
            Jump();
        }
       
    }   
        public void Jump()
    { 
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            body.AddForce(Vector3.up * 3000);
        }

    }
     
}
