using UnityEngine;
using System.Collections;

public class CreditScrollScript : MonoBehaviour {

	public GameObject camera;
	public float speed = 1.2f;
	public float restartTime = 50f;


	void Update()
	{

		camera.transform.Translate (Vector3.down * Time.deltaTime * speed);
		Invoke ("restartCredits", restartTime);
	}


	void restartCredits()
	{
		Application.LoadLevel (3);
	}
}
