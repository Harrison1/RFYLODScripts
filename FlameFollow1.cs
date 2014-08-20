using UnityEngine;
using System.Collections;

public class FlameFollow1 : MonoBehaviour {

	public Transform player;

	void Update() 
	{
		transform.position = new Vector3 (player.position.x - 10, 0, 0);
	}
}