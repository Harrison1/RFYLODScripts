using UnityEngine;
using System.Collections;

public class LightChangeColor : MonoBehaviour {

	public float startTime = 4f;
	public float resetTime = 5f;

	public Light dirLight;

	public Color32 darkRed = new Color();
	public Color32 darkGreen = new Color();
	public Color32 darkBlue = new Color();

	void Awake()
	{
		dirLight.color = Color.white;
		StartCoroutine("ChangeColor");
	}

	IEnumerator ChangeColor()
	{
		while(true)
		{
			//dirLight.color = Color.gray;
			//yield return new WaitForSeconds(resetTime);
			yield return new WaitForSeconds(startTime);
			dirLight.color = darkRed;
			yield return new WaitForSeconds(resetTime);
			dirLight.color = darkGreen;
			yield return new WaitForSeconds(resetTime);
			dirLight.color = darkBlue;
			yield return new WaitForSeconds(resetTime);
			dirLight.color = darkRed;
		}
	
	}
}
