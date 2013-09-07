using UnityEngine;
using System.Collections;

public class PickupSpawner : MonoBehaviour {

	public GameObject pickUp;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating("Spawn", 2.2f, 2.2f);
	}

	void Spawn()
	{
		Instantiate(pickUp);
	}
}
