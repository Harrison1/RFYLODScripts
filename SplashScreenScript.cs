using UnityEngine;
using System.Collections;

public class SplashScreenScript : MonoBehaviour {

	public GameObject verse;
	public GameObject squirells;

	void Update()
	{
		Invoke ("squirrelsScreen", 3);
		Invoke ("startGame", 6);
	}
	
	
	void squirrelsScreen()
	{
		verse.SetActive (false);
		squirells.SetActive(true);
	}

	void startGame()
	{
		Application.LoadLevel(1);
	}
}

