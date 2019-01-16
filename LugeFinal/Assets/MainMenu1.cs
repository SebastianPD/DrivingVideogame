using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour {

	    public void PlayGame ()
		{
			SceneManager.LoadScene("level 3");
		}

		public void QuitGame ()
		{
			Debug.Log("QUIT");
			Application.Quit();
		
	    }

}
