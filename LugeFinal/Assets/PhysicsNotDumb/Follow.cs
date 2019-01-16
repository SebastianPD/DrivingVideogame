/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}*/

using UnityEngine;



public class Follow : MonoBehaviour {
	public Vector3 RotOffset;
	public Transform Player;
	public Vector3 Offset;

	// Update is called once per frame
	void Update () {
		transform.position = Player.position + Offset;
		transform.rotation = Player.rotation;
	}
}
