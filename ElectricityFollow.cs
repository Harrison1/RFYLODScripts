using UnityEngine;
using System.Collections;

public class ElectricityFollow : MonoBehaviour {

	public Transform player;
	
	void Update() 
	{
		transform.position = new Vector3 (player.position.x - 10, player.position.y, player.position.z);
	}
}
