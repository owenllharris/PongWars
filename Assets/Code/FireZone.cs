using UnityEngine;
using System.Collections;

public class FireZone : MonoBehaviour {

	public GameObject puk;

	bool checkForFinish = false;

	Vector3 startPos = Vector3.zero;
	Vector3 endPos = Vector3.zero;

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			Touch();
		}
		if( checkForFinish )
		{
			if( Input.GetMouseButtonUp(0))
			{
				TouchFinish();
			}
		}

	}

	void Touch()
	{
		Ray theTouch = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(theTouch, out hit, 20f))
		{
			if( hit.collider == collider)
			{
				startPos = hit.point;

				checkForFinish = true;
			}
		}
	}

	void TouchFinish()
	{
		checkForFinish = false;
		Ray theTouch = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(theTouch, out hit, 20f))
		{
			if( hit.collider == collider )
			{
				endPos = hit.point;

				Fire();
			}
		}
	}

	void Fire()
	{
		Vector3 spawnPoint = endPos;
		spawnPoint.z = 0;
		GameObject newPuk = Instantiate(puk, spawnPoint, puk.transform.rotation) as GameObject;
		newPuk.transform.parent = transform;
		newPuk.rigidbody.AddForce( (endPos - startPos) * Vector3.Distance(endPos, startPos) * 20, ForceMode.VelocityChange);

	}
}
