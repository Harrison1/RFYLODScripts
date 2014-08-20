using UnityEngine;
using System.Collections;

public class OnMouseClick : MonoBehaviour {

	public Texture2D button1;
	public Texture2D button2;
	
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		   Application.LoadLevel (2);
	}

	void OnMouseEnter() {
		guiTexture.texture = button2;
	}

	void OnMouseExit()
	{
		guiTexture.texture = button1;
	}
}
