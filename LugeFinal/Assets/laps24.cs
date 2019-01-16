using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class laps24 : MonoBehaviour { 
    private int count;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update() { }

	    private void OnTriggerEnter(Collider other)
	    {
		Debug.Log(count);

		if (other.gameObject.CompareTag("Player"))
		{
			count = count + 1;
			Debug.Log(count);

			if (count == 4)
			{
				SceneManager.LoadScene (0);
			Debug.Log("You win!");
		}

		}

	}

}