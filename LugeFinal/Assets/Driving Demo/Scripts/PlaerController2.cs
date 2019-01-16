using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerController2 : MonoBehaviour {

    public float v=0;
    public float maxV=1;
    public float a = 0.1f;
    public float Da = 0.1f;

    public float z = 0;
    public float maxz = 45;
    public float ra = 45f;
    public float rDa = 45f;

    private Rigidbody rb;

    



    // Update is called once per frame
    void Update()
    {

        //This is to make the car accelerate and deccelerate

        if (Input.GetKeyDown(KeyCode.W) && v < maxV)
        {
			if (v > 0) {
				v = v;

			} else {
				v = 0;
			}
           
        }
		else if (Input.GetKeyDown(KeyCode.S) && v > -maxV)
        {
			if (v < 0) {
				v = v;

			} else {
				v = 0;
			}
        }



        if (Input.GetKey(KeyCode.W) && v < maxV)
        {
            v = v + a * Time.deltaTime;
        }
		else if (Input.GetKey(KeyCode.S) && v > -maxV)
        {
            v = v - a * Time.deltaTime;
        }
        else
        {
            if (v > Da * Time.deltaTime)
            {
                v = v - Da * Time.deltaTime;


            }
            else if (v < -Da * Time.deltaTime)
            {
                v = v + Da * Time.deltaTime;

            }
            else
            {
                v = 0;
            }

        }

        transform.Translate(0, 0, v);


        // This is to get rotation and 'Drifting'
        if (Input.GetKey(KeyCode.Space))
        {

            //rb.freezeRotation=true;

            transform.Rotate(0, 0, 0);
        }
        else
        {
            if (Input.GetKey(KeyCode.D) && z < maxz)
            {
                z = z + ra * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, z, 0);
            }
            else if (Input.GetKey(KeyCode.A) && z > -maxz)
            {
                z = z - ra * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, z, 0);
            }
            else
            {
                if (z > rDa * Time.deltaTime)
                {
                    z = z - rDa/2 * Time.deltaTime;
                    transform.rotation = Quaternion.Euler(0, z, 0);


                }
                else if (z < -rDa/2 * Time.deltaTime)
                {
                    z = z + rDa * Time.deltaTime;
                    transform.rotation = Quaternion.Euler(0, z, 0);

                }
                else
                {
                    z = z;
                }

            }


        }

        
    }


    //destroy(other.gameObject);
}





//comment Graveyard
/* 
   
   var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
   v = v + a * Time.time; 

   // Use this for initialization
	void Start () {

		
	}


     if ( Input.GetKey(KeyCode.W))
        {

             v = v + x * Time.deltaTime;
            
        }

        while (b && v>0) {

            timeLeft -= Time.deltaTime;

            if (timeLeft == 0)
            {
                v = v - a * Time.time;
                timeLeft = 30.0f;
            }
                
                }


        if (v < 0) {

            v = 0;
        }


      if (transform.rotation.eulerAngles.y > 45)
        {
         
            transform.rotation = Quaternion.Euler(0, 45, 0);
        
        }

        else if (transform.rotation.eulerAngles.y < 315)
        {

            transform.rotation = Quaternion.Euler(0, -45, 0);

        }
        else
        {

            z = Input.GetAxis("Horizontal") * Time.deltaTime * 300.0f;
        }

    }


     */
