using UnityEngine;
using System.Collections;

public class GameOverScoreDisplay : MonoBehaviour {

	//int playerScore = 0;
	public float highest = 0;
	public float currentScore2 = 0;
	public GUIStyle scoreStyle;
	public Vector2 scaleOnRatio1 = new Vector2(0.5f, 0.5f);
	private Transform myTrans;
	private float widthHeightRatio;
	private float heightWidthRatio;
	private float screenWidthRatio;
	private float xPos;
	private float yPos;
	public Texture2D[] myArray; // slot in your textures on the editor.
	int myScore = 12345; // Put any number int textureDimension = 50;
	int textureDimension = 50;

	void Start () 
	{
		//HUDscore = FindObjectOfType<HUDScript>();
		highest = PlayerPrefs.GetInt("HighScore");
		currentScore2 = PlayerPrefs.GetInt ("CurrentScore");
		myTrans = transform;
		SetScale();
		xPos = Screen.width; 
		yPos = Screen.height;
	}

	void SetScale()
	{
		//find the aspect ratio
		widthHeightRatio = (float)Screen.width / Screen.height;
		//heightWidthRatio = (float)Screen.height/Screen.width * Screen.width;
		screenWidthRatio = (float)Screen.width / Screen.width;
		//Apply the scale. We only calculate y since our aspect ratio is x (width) authoritative: width/height (x/y)
		//myTrans.localScale = new Vector3 (scaleOnRatio1.x * screenWidthRatio, scaleOnRatio1.y, 1);
	}

	void OnGUI()
	{
	//	string myStringScore = myScore.ToString();

	//	for (int i =0; i < myStringScore.Length; i++)
	//		GUI.DrawTexture(new Rect(i * textureDimension , 0, textureDimension ,textureDimension), myArray[int.Parse(myStringScore[i])]);

		//widthHeightRatio = (float)Screen.width / Screen.height;
		GUI.Label (new Rect(Screen.width * 0.55f, Screen.height * 0.36f, Screen.width * 0.05f, Screen.height * 0.05f),(int)(currentScore2 * 100 / 30) + " M", scoreStyle);
		GUI.Label (new Rect(Screen.width * 0.55f, Screen.height * 0.54f, xPos/5, yPos/5), (int)(highest * 100 / 30) + " M", scoreStyle);
	}
}