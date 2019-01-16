using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public Rigidbody RB;
    public float FWforce = 0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RB.AddForce(0, 0, FWforce * Time.deltaTime);
	}
}
