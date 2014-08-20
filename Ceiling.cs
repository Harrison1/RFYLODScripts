using UnityEngine;
using System.Collections;

public class Ceiling : MonoBehaviour {

	public Transform player;

	void Update() 
	{
		transform.position = new Vector3 (player.position.x + 6, transform.position.y, player.position.z);
	}
}
