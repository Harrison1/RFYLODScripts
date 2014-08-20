using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	public static float playerScore = 0;
	public static float hiscore = 0;
	public static string highScoreKey = "HighScore";
	public static string currentScore = "CurrentScore";
	public GUIStyle scoreStyle;

	void Start()
	{
		hiscore = PlayerPrefs.GetInt(highScoreKey,0);
		playerScore = 0;
		Debug.Log("StartHigh = " + PlayerPrefs.GetInt(highScoreKey));
	}

	void HighScore()
	{
		hiscore = PlayerPrefs.GetInt(highScoreKey,0);
	}

	void Update () {

		playerScore += Time.deltaTime;
		//PlayerPrefs.SetInt("Distance", ((int)(playerScore * 100 / 30)));
		
	}

	public void IncreasingScore(int amount)
	{
		playerScore += amount;

	}

	public void OnDisable()
	{
		PlayerPrefs.SetInt(currentScore, (int)playerScore);

		if(playerScore>hiscore)
		{
			PlayerPrefs.SetInt(highScoreKey, (int)playerScore);
			PlayerPrefs.Save();
			Debug.Log ("HighScore = " + PlayerPrefs.GetInt(highScoreKey));
		}
		//PlayerPrefs.SetInt("Distance", ((int)(playerScore * 100 / 30))); //not secure score
		//if(playerScore > PlayerPrefs.GetInt("Distance"))
		//{ 
		//   hiscore = playerScore;
		//}

		//   PlayerPrefs.SetInt("Hiscore", ((int)hiscore * 100 / 30));
	}

	//void OnDestroy()
	//{
	//	PlayerPrefs.SetInt("hiscore", (int)hiscore);
		//PlayerPrefs.SetInt("Distance", ((int)(playerScore * 100 / 30))); //not secure score
	//}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 200, 30),(int)(playerScore * 100 / 30) + " meters", scoreStyle);
		//GUI.Label (new Rect (30, 30, 200, 30), (int)(hiscore * 100 / 30) + " meters", scoreStyle);
	}
}
