using UnityEngine;
using System.Collections;

public class FlameObstacle : MonoBehaviour {

	public Transform player;
	//public GameObject boost1;
	//public GameObject boost2;
	//public GameObject jumpButton;
	//public float playerPos;
	//public float speed;
	//public float waitTime = 4f;
	//PlatformerCharacter2D HelmatMan1;
	//PlayerController2 HelmatMan2;
	//FireBoost FireBoost;
	ElectricityThatKills electricity;
	PlatformerCharacter2D HelmatMan1;
	PlayerController2 HelmatMan2;

	void Start()
	{
		//playerPos = player.position.x;
		electricity = FindObjectOfType<ElectricityThatKills>();
		HelmatMan1 = FindObjectOfType<PlatformerCharacter2D>();
		HelmatMan2 = FindObjectOfType<PlayerController2>();
	/*	HelmatMan1 = FindObjectOfType<PlatformerCharacter2D>();
		HelmatMan2 = FindObjectOfType<PlayerController2>();
		FireBoost = FindObjectOfType<FireBoost> ();*/
	}

	//void LoadLevel()
//	{
//		Application.LoadLevel (1);
//	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			electricity = FindObjectOfType<ElectricityThatKills>();
			electricity.KillSpeed();
			HelmatMan1.Move (0);
			HelmatMan2.enabled = false;
			/*HelmatMan1.enabled = false;
			HelmatMan1.Move(0);
			HelmatMan2.enabled = false;
			FireBoost.enabled = false;
			boost1.SetActive(false);
			boost2.SetActive(false);
			player.rigidbody2D.isKinematic = true;
			jumpButton.SetActive(false);
			//yield return new WaitForSeconds(waitTime);
			Invoke("LoadLevel", 4);		*/
		}
	}
}

