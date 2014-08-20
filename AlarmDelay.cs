using UnityEngine;
using System.Collections;

public class AlarmDelay : MonoBehaviour {

	public AudioSource[] sounds;
	public AudioSource noise1;
	public AudioSource noise2;
	public AudioSource noise3;
	public float startTime = 7f;


	void Awake()
	{
		StartCoroutine("AlarmSound");
	}

	void Start () {
		sounds = GetComponents<AudioSource>();
		noise1 = sounds[0];
		noise2 = sounds[1];
		noise3 = sounds [2];
	}

//	void FixedUpdate()
//	{
//		noise3.PlayDelayed(startTime);
//	}

	
	IEnumerator AlarmSound()
	{
		while(true)
		{
			yield return new WaitForSeconds(startTime);
			noise3.Play();
			yield return new WaitForSeconds(startTime + 40);
		}
	}
}

//	void Update () {
//		yield return new WaitForSeconds(startTime);
//		noise3.Play ();
//	}
