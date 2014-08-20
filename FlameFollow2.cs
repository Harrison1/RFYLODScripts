using UnityEngine;
using System.Collections;

public class FlameFollow2 : MonoBehaviour {

	public Transform player;
	
	void Update() 
	{
		transform.position = new Vector3 (player.position.x - 10, 30, 0);
	}
}
