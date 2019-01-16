/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI1 : MonoBehaviour {

	public Rigidbody RB;
	public int FWforce = 0;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		RB.AddForce(0, 0, 700 * Time.deltaTime);
	}
}
