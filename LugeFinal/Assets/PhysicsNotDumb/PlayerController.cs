/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {

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

		if(Input.GetKeyDown(KeyCode.W)){
			v = 0;

		}

		if(Input.GetKeyDown(KeyCode.S))
		{
			v = 0;

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


		// This is to get rotation
		//var z = Input.GetAxis("Horizontal") * Time.deltaTime * 300.0f;







		// This is for 'Drifting'
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
}
