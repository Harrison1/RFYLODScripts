using UnityEngine;
using System.Collections;

public class GameOverRestart : TouchLogicV2 {

	public Texture2D button1;
	public Texture2D button2;

	void Start() 
	{
		guiTexture.texture = button1;	
	}

	void Update () 
	{
		foreach (Touch touch in Input.touches)
		{
			if (guiTexture.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
			{
				guiTexture.texture = button2;
				
				Application.LoadLevel(2);
			}
			else if (guiTexture.HitTest(touch.position) && touch.phase == TouchPhase.Ended)
			{
				guiTexture.texture = button1;
			}
		}
	}
}
