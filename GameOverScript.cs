using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int distance = 0;

	void Start () {
		distance = PlayerPrefs.GetInt("Distance");
	}
	

	void OnGUI () 
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");

		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Distance: " + distance);

		if(GUI.Button (new Rect(Screen.width / 2 - 40, 350, 100, 30), "Try Again"))
		{
			Application.LoadLevel (2);
		}
	}
}
