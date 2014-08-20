using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlatformerCharacter2D))]
public class PlayerController2 : MonoBehaviour {

	private PlatformerCharacter2D character;
	private bool jump;

	void Awake () {
		character = GetComponent<PlatformerCharacter2D> ();
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


