using UnityEngine;
using System.Collections;

public class CreditScript : MonoBehaviour {

	public Texture2D button1;
	public Vector2 scaleOnRatio1 = new Vector2(0.2f, 0.1f);
	private Transform myTrans;
	private float widthHeightRatio;
	private float heightWidthRatio;
	private float screenWidthRatio;
	
	void Start() 
	{
		guiTexture.texture = button1;	
		myTrans = transform;
		SetScale();
	}
	
	void SetScale()
	{
		//find the aspect ratio
		//widthHeightRatio = (float)Screen.width / Screen.height * Screen.height;
		//heightWidthRatio = (float)Screen.height/Screen.width * Screen.width;
		screenWidthRatio = (float)Screen.width / Screen.width;
		
		//Apply the scale. We only calculate y since our aspect ratio is x (width) authoritative: width/height (x/y)
		myTrans.localScale = new Vector3 (scaleOnRatio1.x * screenWidthRatio, scaleOnRatio1.y, 1);
	}
	
	void Update () 
	{
		foreach (Touch touch in Input.touches)
		{
			if (guiTexture.HitTest(touch.position) && touch.phase != TouchPhase.Ended)
			{
				guiTexture.texture = button1;
				
				Application.LoadLevel(3);
			}
		}
	}
}