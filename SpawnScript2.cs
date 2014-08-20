using UnityEngine;
using System.Collections;

public class SpawnScript2 : MonoBehaviour {

	public float life = 25.0f;
	public float speed = 0.0f;
	private float timeToDie = 0.0f;
	public Transform player;
	public float playerX;
	public float playerY;
	
	public GameObject playerObj;
	//public float playerPos;

	void Start() {
		playerObj = GameObject.FindWithTag("Player");
//		playerPos = playerObj.transform.position;
		playerX = playerObj.transform.position.x;
	}

	void Update () 
	{
		//playerX = player.position.x;
		CountDown();
		AutoMove();
	}

	public void Activate()
	{
		playerObj = GameObject.Find("HelmatMan");
		playerX = playerObj.transform.position.x;
		timeToDie = Time.time + life;
		//playerX = player.position.x;
		transform.position = new Vector3(playerX + 66f, 22.72591f, 0);
	}

	private void Deactivate()
	{
		this.gameObject.SetActive(false);
	}

	private void CountDown()
	{
		if (timeToDie < Time.time)
		{
			Deactivate();
		}
	}

	private void AutoMove()
	{
		Vector3 velocity = speed * Time.deltaTime * (transform.right*(-1));
		transform.Translate(velocity);
	}
}
