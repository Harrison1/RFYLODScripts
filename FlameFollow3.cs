using UnityEngine;
using System.Collections;

public class FlameFollow3 : MonoBehaviour {

	public Transform player;
	
	void Update() 
	{
		transform.position = new Vector3 (player.position.x - 10, 60, 0);
	}
}
