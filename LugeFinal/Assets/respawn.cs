using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

    public float zLimit;
    public float yLimit;
    public float xLimit;
    public float interval = 5;
    public float Startinterval = 5;

    private float currentx;
    private float currenty;
    private float previousy;
    private float previousx;
    private float currentz;
    public Transform thing;

    private float xPosition;
    private float yPosition;
    private float zPosition;
    private Rigidbody rb;

    private bool nottouching = false;

    private Vector3 position;


    // Use this for initialization
    void Start () {

        currentx = thing.transform.position.x;
        currenty = thing.transform.position.y;
        currentz = thing.transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {
        interval -= Time.deltaTime;
        if (interval < 0)

        {
            xPosition = thing.transform.position.x;
            yPosition = thing.transform.position.y;
            zPosition = thing.transform.position.z;

            position = new Vector3(xPosition,yPosition,zPosition);

            interval = Startinterval;
        
        }

        currentx = thing.transform.position.x;
        currenty = thing.transform.position.y;
        currentz = thing.transform.position.z;

        previousy = yPosition;
        previousx = xPosition;

        if (currentx < xLimit)
        {

        }

       if ((((currenty - previousy)/Time.deltaTime) < -50) ) //|| thing.transform.position.y < yLimit) 
        {
           // Debug.Log("TRUE");
            interval = Startinterval;
          //  thing.transform.position = position;
           // float yvel = ((currenty - previousy) / Time.deltaTime);
            // yvel = 0;
        } 
   

        if (thing.transform.position.y < yLimit)
        {
            interval = Startinterval;
            thing.transform.position = position;
    
      
        }
        if (currentz < zLimit)
        {

        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Track")

        {
            Debug.Log("true");
            nottouching = false;
        }

        else { nottouching = true;
            Debug.Log("flase");
        }
    }
}



         
        



