using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class laps : MonoBehaviour
{
    private int count = 0;
    private int count2 = 0;

    // Use this for initialization
    void Start()
    {

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
                SceneManager.LoadScene(4);
                Debug.Log("You win!");
            }

        }

        if (other.gameObject.CompareTag("AI"))
        {
            count2 = count2 + 1;
            Debug.Log(count);

            if (count2 == 4)
            {
                SceneManager.LoadScene(4);
                Debug.Log("You lose!");
            }
            // TO DO make a seperate ai counter and compare
        }
    }

}