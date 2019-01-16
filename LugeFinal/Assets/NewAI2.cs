using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAI2 : MonoBehaviour {

	public Transform path;
	private List<Transform> nodes;
	private int currentNode = 0;

	public float MaxSteerAngle = 40f;

	public WheelCollider r;
	public WheelCollider l;

	public float a = 0.1f;

    public Transform thing;

    public float MaxMotorTorque = 50f;
	public float currentSpeed = 0;
	public float maxSpeed = 100f;

	// Use this for initialization
	void Start () {
		Transform[] pathTransform = path.GetComponentsInChildren<Transform>();
		nodes = new List<Transform>();

		for (int i = 0; i < pathTransform.Length; i++)
		{
			if (pathTransform[i] != path.transform)
			{
				nodes.Add(pathTransform[i]);

			}
		}
	}

	// Update is called once per frame
	void FixedUpdate () {

        if (thing.transform.rotation.z > 90)

        {


        }

        ApplySteer();

		Drive();

		CheckWayPointDistance();
	}
	private void ApplySteer() {
		Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
		float newSteer = (relativeVector.x / relativeVector.magnitude)*MaxSteerAngle;

		r.steerAngle = newSteer;
		l.steerAngle = newSteer;


	}
	private void Drive() {

		//currentSpeed = (2 * Mathf.PI * r.radius * l.rpm * 60/1000) + a * Time.deltaTime;
		currentSpeed = currentSpeed + 2* a * Time.deltaTime;
		r.motorTorque = currentSpeed;
		l.motorTorque = currentSpeed;

        if (currentSpeed > maxSpeed) {

            currentSpeed = maxSpeed;
        }

		// currentSpeed = currentSpeed + a * Time.deltaTime;
		// transform.Translate(0, 0, currentSpeed*.1f);

		/*  if (currentSpeed < maxSpeed)
          {

              // r.motorTorque = currentSpeed;
               //l.motorTorque = currentSpeed;
              r.motorTorque = MaxMotorTorque;
               l.motorTorque = MaxMotorTorque;
          }
          else if (currentSpeed > maxSpeed)
          {
              r.motorTorque = 0;
              l.motorTorque = 0;

            //  r.motorTorque = maxSpeed;
             // l.motorTorque = maxSpeed;
          }*/

	}
	private void CheckWayPointDistance()
	{
		if (Vector3.Distance(transform.position, nodes[currentNode].position) < 0.5f) {
			if(currentNode == nodes.Count - 1)
			{
				currentNode = 0;
			} else {
				currentNode++;
			}
		}

	}
}
