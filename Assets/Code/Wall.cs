using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	void OnCollisionEnter()
	{
		Destroy(gameObject);
	}
}
