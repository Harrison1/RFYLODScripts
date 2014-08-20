using UnityEngine;
using System.Collections;

public class JumpGUI : TouchLogicV2 
	{
		PlatformerCharacter2D player;
		FireBoost boost;
		GUITexture screenFit;

		void Awake()
		{
			screenFit = guiTexture;
			screenFit.guiTexture.pixelInset = new Rect (0, 0, Screen.width, Screen.height);
		}
		void Start()
		{
			player = FindObjectOfType<PlatformerCharacter2D>();
			boost = FindObjectOfType<FireBoost> ();
		}
		
		public override void OnTouchBegan()
		{
			player.Jump(true);
			boost.pe.Play();
			boost.lastSpaceTime = Time.time;
			//boost.Play();
			boost.audio.Play ();
		}
	}