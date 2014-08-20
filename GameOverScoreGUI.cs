using UnityEngine;
using System.Collections;

public class GameOverScoreGUI : MonoBehaviour {

	public Vector2 scaleOnRatio1 = new Vector2(0.05f, 0.11f);
	private Transform myTrans;
	private float widthHeightRatio;
	private float screenWidthRatio;
	
	void Start () 
	{
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
}
