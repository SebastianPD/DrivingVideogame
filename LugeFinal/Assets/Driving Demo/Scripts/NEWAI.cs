using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWAI : MonoBehaviour {
    public float v = 0;
    public float maxV = 1;
    public float a = 0.1f;
    public float Da = 0.1f;

    public float z = 0;
    public float maxz = 45;
    public float ra = 45f;
    public float rDa = 45f;

    public float distance = 0;
    public Transform Wall;
    public Transform Wall2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        v = v + a * Time.deltaTime;
        transform.Translate(0, 0, v);
    }
}
