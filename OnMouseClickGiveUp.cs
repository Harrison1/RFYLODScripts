using UnityEngine;
using System.Collections;

public class OnMouseClickGiveUp : MonoBehaviour {

	public Texture2D button1;
	public Texture2D button2;

	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
			Application.LoadLevel (1);
	}
	
	void OnMouseEnter() {
		guiTexture.texture = button2;
	}
	
	void OnMouseExit()
	{
		guiTexture.texture = button1;
	} 
}
