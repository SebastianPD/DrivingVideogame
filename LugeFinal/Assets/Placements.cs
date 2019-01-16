using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placements : MonoBehaviour {

   

    public Transform thing1;
	public Transform thing2;
	public Transform thing3;

	private float trackingX1;
	private float trackingX2;
	private float trackingX3;

	private float tracking2X1;
	private float tracking2X2;
	private float tracking2X3;

	private float total1=0;
	private float total2=0;
	private float total3=0;

	private float Ntotal1=0;
	private float Ntotal2=0;
	private float Ntotal3=0;

	public float interval = 1;
	public float Startinterval = 1;

	// Use this for initialization
	void Start () {

		trackingX1 = thing1.transform.position.z;
		trackingX2 = thing2.transform.position.z;
		trackingX3 = thing3.transform.position.z;

	}

	// Update is called once per frame
	void Update () {
		interval -= Time.deltaTime;
		if (interval < 0) {
			tracking2X1 = thing1.transform.position.z;
			tracking2X2 = thing2.transform.position.z;
			tracking2X3 = thing3.transform.position.z;



			total1 = (tracking2X1 - trackingX1);
			total2 = (tracking2X2 - trackingX2);
			total3 = (tracking2X3 - trackingX3);

				if (total1 < 0) {
				total1 = -1 * total1;
			
			}

		
			if (total2 < 0) {
				total2 = -1 * total2;

			}
			if (total3 < 0) {
				total3 = -1 * total3;

			} 

			Ntotal1 = total1 + Ntotal1;
			Ntotal2 = total2 + Ntotal2;
			Ntotal3 = total3 + Ntotal3;

			trackingX1 = tracking2X1;
			trackingX2 = tracking2X2;
			trackingX3 = tracking2X3;

			interval = Startinterval;
		}

		//Debug.Log (Ntotal1);
			if ((total1 > total2) && (total1 > total3)) {

				Debug.Log ("You are winning");
			}

		
	}
}