using UnityEngine;
using System.Collections;

public class SpriteScoreScriptH1 : MonoBehaviour {

	public float highScore = 0;
	char[] scoreArray; 
	string scoreString;
	public GameObject number0;
	public GameObject number1;
	public GameObject number2;
	public GameObject number3;
	public GameObject number4;
	public GameObject number5;
	public GameObject number6;
	public GameObject number7;
	public GameObject number8;
	public GameObject number9;
	
	void Start () 
	{
		highScore = PlayerPrefs.GetInt("HighScore");
		highScore = (int)(highScore * 100 / 30);
		scoreArray = highScore.ToString().ToCharArray();
		
		if(scoreArray[scoreArray.Length - 1].Equals('0'))
			number0.SetActive(true);
		
		if(scoreArray[scoreArray.Length - 1].Equals('1'))
			number1.SetActive(true);
		
		if(scoreArray[scoreArray.Length - 1].Equals('2'))
			number2.SetActive(true);
		
		if(scoreArray[scoreArray.Length - 1].Equals('3'))
			number3.SetActive(true);
		
		if(scoreArray[scoreArray.Length - 1].Equals('4'))
			number4.SetActive(true);
		
		if(scoreArray[scoreArray.Length - 1].Equals('5'))
			number5.SetActive(true);
		
		if(scoreArray[scoreArray.Length - 1].Equals('6'))
			number6.SetActive(true);
		
		if(scoreArray[scoreArray.Length - 1].Equals('7'))
			number7.SetActive(true);
		
		if(scoreArray[scoreArray.Length - 1].Equals('8'))
			number8.SetActive(true);
		
		if(scoreArray[scoreArray.Length - 1].Equals('9'))
			number9.SetActive(true);
		
	}
}