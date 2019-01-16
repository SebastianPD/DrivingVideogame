using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAI3 : MonoBehaviour {

    public Transform path;
    private List<Transform> nodes;
    private int currentNode = 0;

    public float MaxSteerAngle = 40f;
    // public Transform thing;

   // public WheelCollider r;
    public WheelCollider l;


    public float z = 0;
    public float maxz = 45;
    public float ra = 45f;
    public float rDa = 45f;

    public float v = 0;
    public float maxV = 1;
    public float a = 0.1f;
    public float Da = 0.1f;

    // Use this for initialization
    void Start()
    {
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
    void FixedUpdate()
    {
        ApplySteer();

        Drive();

        CheckWayPointDistance();
    }
    private void ApplySteer()
    {
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
        //relativeVector = relativeVector / relativeVector.magnitude;
        float newSteer = (relativeVector.x / relativeVector.magnitude) * MaxSteerAngle;
        //thing.rotation = Quaternion.Euler(newSteer, newSteer, newSteer);

       // r.steerAngle = newSteer;
        l.steerAngle = newSteer;

        //thing.localRotation = Quaternion.Euler(0, newSteer, 0);
        //thing.localRotation.SetEulerRotation(0, newSteer, 0);


    }
    private void Drive()
    {
        //v = v + a * Time.deltaTime;
        //transform.Translate(0, 0, v);
       // r.motorTorque = 50f;
        l.motorTorque = 50f;

    }
    private void CheckWayPointDistance()
    {
        if (Vector3.Distance(transform.position, nodes[currentNode].position) < 0.5f)
        {
            if (currentNode == nodes.Count - 1)
            {
                currentNode = 0;
            }
            else
            {
                currentNode++;
            }
        }

    }
}
