using UnityEngine;
using System.Collections;

public class DestroyAfterDelay : MonoBehaviour {

	public float delay = 25.0f;
	
	void Update () 
	{
		Destroy(gameObject, 25);
	}

	//void Destr() 
	//{
	//	yield return new WaitForSeconds(delay);
	//	Destroy(gameObject);
	//}
}