using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour {

    public Transform AI2;
    public Transform AI1;
    public Transform player;
    public Text ScoreText;


    // Update is called once per frame
    void Update()
    {
        if (player.position.z > AI1.position.z && player.position.z > AI2.position.z)
        {

            ScoreText.text = ("1st Place");
        }

        else if (AI1.position.z > player.position.z && AI2.position.z > player.position.z)
        {
            ScoreText.text = ("3rd Place");
        }
        else { ScoreText.text = ("2nd Place"); }
        //ScoreText.text = player.position.z.ToString("0") +"_______"+ AI1.position.z.ToString("0");
    }


    // Use this for initialization
    void Start () {
		
	}
}
