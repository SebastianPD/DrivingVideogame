using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkpoint : MonoBehaviour {

    // Update is called once per frame

    private int count;
    private int scoreInt;
    private int scoreInt1;
    private int scoreInt2;
    //public Text countText;
    public Text score;

    private void Start()
    {
        count = 0;
        scoreInt = 0;
        scoreInt1 = 0;
        scoreInt2 = 0;
        //SetCountText();
    }

    void Update ()

    {

    }

    private void OnTriggerEnter(Collider other)
    {
        count = count + 1;
      

        if (other.gameObject.CompareTag("Player"))
        {
            //gameObject.SetActive(false);
           // count = count - 1;
           if (count == 2) { score.text = ("Score: 10"); scoreInt = 10; }
            if (count == 3) { score.text = ("Score: 8"); scoreInt = 8; }
            if (count == 4) { score.text = ("Score: 6"); scoreInt = 6; }
        }

        if (other.gameObject.CompareTag("AI"))
        {
            //gameObject.SetActive(false);
            // count = count - 1;
            if (count == 2) {  scoreInt1 = 10; }
            if (count == 3) {  scoreInt1 = 8; }
            if (count == 4) {  scoreInt1 = 6; }
        }
        if (other.gameObject.CompareTag("AI1"))
        {
            //gameObject.SetActive(false);
            // count = count - 1;
            if (count == 2) { scoreInt2 = 10; }
            if (count == 3) { scoreInt2 = 8; }
            if (count == 4) { scoreInt2 = 6; }
        }



        Debug.Log(scoreInt);
        Debug.Log(scoreInt1);
        Debug.Log(scoreInt2);
    }

    void SetCountText() {
        //countText.text = "Count: " + count.ToString();

    }

}
