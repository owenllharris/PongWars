using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	public GameObject particle;

	void OnCollisionEnter()
	{
		Instantiate( particle, transform.position, Quaternion.identity );

		Destroy(gameObject);
	}
}
