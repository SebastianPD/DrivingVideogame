using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class laps25 : MonoBehaviour {

    public Text ScoreText;

    public float interval2 = 0;
    private bool gate = false;

    private int count = 0;
    private int count2 = 0;

    public Transform thing1;
    public Transform thing2;
    public Transform thing3;

    private float trackingX1;
    private float trackingX2;
    private float trackingX3;

    private float tracking2X1;
    private float tracking2X2;
    private float tracking2X3;

    private float total1 = 0;
    private float total2 = 0;
    private float total3 = 0;

    private float Ntotal1 = 0;
    private float Ntotal2 = 0;
    private float Ntotal3 = 0;

    public float interval = 1;
    public float Startinterval = 1;

    private bool isFirst = false;

    // Use this for initialization
    void Start () {

        trackingX1 = thing1.transform.position.z;
        trackingX2 = thing2.transform.position.z;
        trackingX3 = thing3.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {

        interval2 -= Time.deltaTime;
        if (interval2 < 0)
        {
            gate = true;
        }
        else { gate = false; }

        interval -= Time.deltaTime;
        if (interval < 0)
        {
            tracking2X1 = thing1.transform.position.z;
            tracking2X2 = thing2.transform.position.z;
            tracking2X3 = thing3.transform.position.z;



            total1 = (tracking2X1 - trackingX1);
            total2 = (tracking2X2 - trackingX2);
            total3 = (tracking2X3 - trackingX3);

            if (total1 < 0)
            {
                total1 = -1 * total1;

            }


            if (total2 < 0)
            {
                total2 = -1 * total2;

            }
            if (total3 < 0)
            {
                total3 = -1 * total3;

            }

            Ntotal1 = total1 + Ntotal1;
            Ntotal2 = total2 + Ntotal2;
            Ntotal3 = total3 + Ntotal3;

            trackingX1 = tracking2X1;
            trackingX2 = tracking2X2;
            trackingX3 = tracking2X3;

            interval = Startinterval;
            if ((total1 > total2) && (total1 > total3) || (count > count2))
            {
                isFirst = true;
                Debug.Log("You are winning");
                ScoreText.text = ("You Are Winning");
            }
            else {
                ScoreText.text = ("You Are Losing");
            }

        }
    }

	    private void OnTriggerEnter(Collider other)
	    {
		Debug.Log(count);

		if (other.gameObject.CompareTag("Player") && gate)
		{
			count = count + 1;
			//Debug.Log(count);

			if ((count == 3) && isFirst)
			{
				SceneManager.LoadScene ("lvl2");
			Debug.Log("You win!");
                ScoreText.fontSize = 144;
                ScoreText.text = ("lvl2");
            }
            interval2 = 5;
        }

        if (other.gameObject.CompareTag("AI"))
        {
            count2 = count2 + 1;
           // Debug.Log(count2);

            if (count2 == 3)
            {
                
                Debug.Log("You Loose!");
                ScoreText.fontSize = 144;
                ScoreText.text = ("YOU LOST");
                SceneManager.LoadScene("Game");
            }

        }

    }

}