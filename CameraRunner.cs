using UnityEngine;
using System.Collections;

public class CameraRunner : MonoBehaviour {

	public Transform player;

	void Update () 
	{
		transform.position = new Vector3(player.position.x + 6, player.position.y + 6, -10);
	}
}
