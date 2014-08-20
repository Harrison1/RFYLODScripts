using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerController3))]
public class PlayerController4 : MonoBehaviour {

	private PlayerController3 character;
	private bool jump;
	
	void Awake () {
		character = GetComponent<PlayerController3> ();
	}
	
	void Update () {
		
		if (CrossPlatformInput.GetButtonDown ("Jump"))
			jump = true;
		
	}
	
	void FixedUpdate()
	{
		character.Move (1);
		character.Jump(jump);
		jump = false;
		
	}
}
