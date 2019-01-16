using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour {

	    public void PlayGame ()
		{
			SceneManager.LoadScene("Game");
		}

		public void QuitGame ()
		{
			Debug.Log("QUIT");
			Application.Quit();
		
	    }

}
