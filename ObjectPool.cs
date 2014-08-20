using UnityEngine;
using System.Collections;

public class ObjectPool : MonoBehaviour {

	GameObject[] sequences = null;
	public int numberOfSequences = 0;
	public GameObject[] newSequence;


	void Start(){
		sequences = new GameObject[numberOfSequences];
		InstantiateSequence ();
		newSequence = Resources.LoadAll("Prefabs") as GameObject[];
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			ActivateSequence();		
			return;
		}
	}

	private void InstantiateSequence()
	{
		for(int i = 0; i < numberOfSequences; i++)
		{
			sequences[i] = Instantiate(newSequence[Random.Range(0,newSequence.Length)]) as GameObject;
			sequences[i].SetActive(false);
		}
	}

	private void ActivateSequence()
	{
		for(int i = 0; i < numberOfSequences; i++)
		{
			if(sequences[i].activeSelf == false)
			{
				sequences[i].SetActive(true);
				sequences[i].GetComponent<SpawnScript2>().Activate();
				return;
			}
		}
	}
}	




	