using UnityEngine;
using System.Collections;

public class GUITextureScrollUp : MonoBehaviour {

	public GameObject credit;
	public float speed = 1.2f;
	public float restartTime = 55f;
	
	
	void Update()
	{
		
		credit.transform.Translate (Vector3.up * Time.deltaTime * speed);
		Invoke ("restartCredits", restartTime);
	}
	
	
	void restartCredits()
	{
		Application.LoadLevel (3);
	}
}

