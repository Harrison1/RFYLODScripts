using UnityEngine;
using System.Collections;

public class DestroyerBottomMove : MonoBehaviour {

	public Transform player;

	void Update() 
	{
		transform.position = new Vector3 (player.position.x + 6, -35, player.position.z);
	}
}