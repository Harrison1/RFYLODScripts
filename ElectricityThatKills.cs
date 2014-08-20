using UnityEngine;
using System.Collections;

public class ElectricityThatKills : MonoBehaviour {

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
	public GameObject fireThatKills;
	public GameObject bottomFire;

	
	void Start()
	{
		playerPos = player.position.x;
		flamePos = transform.position.x;
		HelmatMan1 = FindObjectOfType<PlatformerCharacter2D>();
		HelmatMan2 = FindObjectOfType<PlayerController2>();
		FireBoost = FindObjectOfType<FireBoost>();
		showGUI = false;
	}

	public void FixedUpdate()
	{
		HelmatMan1 = FindObjectOfType<PlatformerCharacter2D>();
		HelmatMan2 = FindObjectOfType<PlayerController2>();
		FireBoost = FindObjectOfType<FireBoost>();
		//transform.position = Vector3.MoveTowards(transform.position, player.position, 5 * Time.deltaTime);
		//transform.position = new Vector3(player.position.x - 5, player.position.y, player.position.z);
		float distance = Vector3.Distance(player.position, transform.position);
		
		if (distance < 60)
		{
			transform.position = Vector3.MoveTowards(transform.position, player.position, 0 * Time.deltaTime);
		} 
		else 
		{
			transform.position = Vector3.MoveTowards(transform.position, player.position, 15 * Time.deltaTime);
		}
	}

	//public void MoveSquare()
	//{
	//	transform.position = new Vector3(player.position.x - 5, player.position.y, player.position.z);
	//}

	public void KillSpeed()
	{
		transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
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
		fireThatKills.SetActive(false);
		bottomFire.SetActive(false);
	}
	
	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			Invoke("KillSpeed", 0f);
			Debug.Log("Electro here");
			HelmatMan1 = FindObjectOfType<PlatformerCharacter2D>();
			HelmatMan2 = FindObjectOfType<PlayerController2>();
			HelmatMan1.enabled = false;
			HelmatMan2.enabled = false;
			FireBoost = FindObjectOfType<FireBoost>();
			//FireBoost.enabled = false;
			boost1.SetActive(false);
			boost2.SetActive(false);
			jumpButton.SetActive(false);
			player.rigidbody2D.isKinematic = true;
			//yield return new WaitForSeconds(waitTime);
			//Invoke("LoadLevel", 8.5f);	
			//showGUI = true;
			Invoke("LoadGameOver", 0.5f);

		}

		if(showGUI==true)
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
		}
	}
}

