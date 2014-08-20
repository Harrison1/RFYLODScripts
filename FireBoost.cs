using UnityEngine;
using System.Collections;

public class FireBoost : MonoBehaviour {

	public float emitTime = 3.0f;
	public float lastSpaceTime = 0;
	public ParticleSystem pe = null;
//	public bool jump;
//	PlatformerCharacter2D player;

	//public AudioSource boost;

	void Start () 
	{
		pe = GetComponent<ParticleSystem> ();
	//	player = FindObjectOfType<PlatformerCharacter2D>();
	//	boost = (AudioSource)gameObject.AddComponent ("AudioSource");
	//	AudioClip boostSound;
		//boostSound = (AudioClip)Resources.Load ("Audio/boost2");
	//	boostSound = AudioClip;
	//	boost.clip = boostSound;
	}

	void Update()
	{
		if (CrossPlatformInput.GetButtonDown("Jump")) 
		{
			pe.Play();
			lastSpaceTime = Time.time;
			//boost.Play();
			audio.Play ();
		}

		if ((pe) && ((Time.time - lastSpaceTime) >= emitTime))
		{
			pe.Stop();
		}
					
	}
}
