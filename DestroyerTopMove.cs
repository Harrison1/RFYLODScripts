using UnityEngine;
using System.Collections;

public class DestroyerTopMove : MonoBehaviour {

	public Transform player;
	public float speed;

	void Update () 
	{
		transform.position = new Vector3(player.position.x - 200, 15, 10);
	}
}