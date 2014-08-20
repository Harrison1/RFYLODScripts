using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

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
	public GameObject bottomFire;

	//public GameObject giveUp;

	void Start()
	{
		playerPos = player.position.x;
		flamePos = transform.position.x;
		HelmatMan1 = FindObjectOfType<PlatformerCharacter2D>();
		HelmatMan2 = FindObjectOfType<PlayerController2>();
		FireBoost = FindObjectOfType<FireBoost>();
		showGUI = false;
	}

	bool PlayerMoved()
	{
		float displacement = player.position.x - playerPos;
		playerPos = player.position.x;
		return displacement > 0.001;
		
	}
	
	void FixedUpdate()
	{
		float distance = Vector3.Distance(player.position, transform.position);

		if (PlayerMoved() && (distance < 50))
		{
			transform.position = Vector3.MoveTowards(transform.position, player.position, 5 * Time.deltaTime);
		} 
		else if (!PlayerMoved()) 
	 	{ 
			transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
		}
		else 
		{
			transform.position = Vector3.MoveTowards(transform.position, player.position, 15 * Time.deltaTime);
		}
	}

	void LoadLevel()
	{
		Application.LoadLevel(2);
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
		bottomFire.SetActive(false);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			HelmatMan1.enabled = false;
			HelmatMan2.enabled = false;
			FireBoost.enabled = false;
			boost1.SetActive(false);
			boost2.SetActive(false);
			jumpButton.SetActive(false);
			Debug.Log("FireHere");
			player.rigidbody2D.isKinematic = true;
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
