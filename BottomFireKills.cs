using UnityEngine;
using System.Collections;

public class BottomFireKills : MonoBehaviour {

	public Transform player;
	public GameObject boost1;
	public GameObject boost2;
	public GameObject jumpButton;
	public float speed;
	public float playerPos;
	public float flamePos;
	public float waitTime = 4f;
	PlatformerCharacter2D HelmatMan1;
	PlayerController2 HelmatMan2;
	FireBoost FireBoost;
	public bool showGUI = false;
	public GameObject runAgain;
	public GameObject giveUp;
	public GameObject gameOver;
	public GameObject showScore;
	public GameObject character;
	public GameObject gameOverScore;
	public GameObject electricityThatKills;
	public GameObject fireThatKills;
	
	void Start()
	{
		HelmatMan1 = FindObjectOfType<PlatformerCharacter2D>();
		HelmatMan2 = FindObjectOfType<PlayerController2>();
		FireBoost = FindObjectOfType<FireBoost> ();
		showGUI = false;
	}
	
	void LoadLevel()
	{
		Application.LoadLevel (2);
	}

	void LoadGameOver()
	{
		//showGUI = true;
		character.audio.enabled = false;
		showScore.SetActive(false);
		gameOver.SetActive(true);
		runAgain.SetActive(true);
		giveUp.SetActive (true);
		gameOverScore.SetActive(true);
		electricityThatKills.SetActive(false);
		fireThatKills.SetActive(false);
	}
	
	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			HelmatMan1.enabled = false;
			HelmatMan2.enabled = false;
			FireBoost.enabled = false;
			boost1.SetActive(false);
			boost2.SetActive(false);
			jumpButton.SetActive(false);
			player.rigidbody2D.isKinematic = true;
			//yield return new WaitForSeconds(waitTime);
			//Debug.Log ("Bottom Fire here");
			//Invoke("LoadLevel", 3.5f);		
			//yield return new WaitForSeconds(waitTime);
			//Invoke("LoadLevel", 8.5f);		
			//showGUI = true;
			Invoke("LoadGameOver", 0.5f);
		}
		/*	if(showGUI==true)
		{
			character.audio.enabled = false;
			showScore.SetActive(false);
			gameOver.SetActive(true);
			runAgain.SetActive(true);
			giveUp.SetActive (true);
			gameOverScore.SetActive(true);
			//GameObject.Find("RunAgain").guiTexture.SetActive(true);  
		}
		else
		{
			character.audio.enabled = true;
			showScore.SetActive(true);
			gameOver.SetActive(false);
			runAgain.SetActive(false);
			giveUp.SetActive(false);
			gameOverScore.SetActive(false);
			//GameObject.Find("RunAgain").SetActive(false);  
		}*/
	}
}

