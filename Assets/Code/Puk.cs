using UnityEngine;
using System.Collections;

public class Puk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("Remove", 5f);
	}
	
	void Remove()
	{
		Destroy(gameObject);
	}
}
