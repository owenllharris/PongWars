using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Vector3 startPos = new Vector3( Random.Range(-2.5f, 2.5f), Random.Range(-2.5f, 2.5f), 0f); 
		transform.position = startPos;
		Invoke("Remove", 4f);
		rigidbody.AddForce(Random.insideUnitCircle.normalized * 0.8f, ForceMode.VelocityChange);

	}


	void Remove()
	{
		Destroy(gameObject);
	}

	void OnTriggerEnter(Collider enterer)
	{
		if(enterer.tag == "Puk")
		{
			enterer.transform.parent.GetComponent<Score>().BuildBlocks += 5;
			Remove();
		}
	}
}
