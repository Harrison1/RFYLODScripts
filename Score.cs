using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	static float score = 0;
	static float hiscore = 0;

	public static void AddPoint(int add) 
	{
		score += add;
		
		if(score > hiscore)
			hiscore = score;
	}

	void Start()
	{
		score = 0;
		AddPoint (1);
		PlayerPrefs.GetFloat("highscore");
	}

	void OnDestroy() 
	{
		PlayerPrefs.SetFloat("highscore", hiscore);
	}

	void Update()
	{
		guiText.text = ((int)score*5) + " m" + "\n" + "Hi-Score: " + hiscore;
		score += Time.deltaTime;
		
	}
}