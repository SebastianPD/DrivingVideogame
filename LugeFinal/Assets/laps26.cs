using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class laps26 : MonoBehaviour {

    public Text ScoreText;

    private int count = 0;
    private int count2 = 0;


    private bool isFirst = false;

    // Use this for initialization
    void Start () {

 
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = ("Get to the End");
    }

	    private void OnTriggerEnter(Collider other)
	    {
		Debug.Log(count);

		if (other.gameObject.CompareTag("Player"))
		{
			count = count + 1;
			//Debug.Log(count);

			if ((count == 1))
			{
				SceneManager.LoadScene ("Game");
			    Debug.Log("You win!");
               
               
            }

		}

        if (other.gameObject.CompareTag("AI"))
        {
            count2 = count2 + 1;
           // Debug.Log(count2);

            if (count2 == 3)
            {
                
                Debug.Log("You Loose!");
        
                SceneManager.LoadScene("Game");
            }

        }

    }

}