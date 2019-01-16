using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float Accelration;
    public float friction;
    private Rigidbody rb;

     


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (Input.GetKey(KeyCode.Space))
        {
            //StopCoroutine("Decellerate");
            
            speed = speed + (Accelration * Time.deltaTime);
            

        }
        else
        {
            
            speed = (speed - (Accelration * Time.deltaTime));
            
        }


        if (speed < 0)
        {
            speed = 0;
           
        }

        rb.AddForce(movement * speed);
    }


}




