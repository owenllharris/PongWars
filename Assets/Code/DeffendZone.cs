using UnityEngine;
using System.Collections;

public class DeffendZone : MonoBehaviour {
	
	public GameObject wall;

	void Update()
	{
		if( Input.GetMouseButtonDown(0) )
		{
			Touch();
		}
	}

	void Touch()
	{
		Ray theTouch = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(theTouch, out hit, 20f))
		{
			if( hit.collider == collider && transform.parent.GetComponent<Score>().BuildBlocks > 0 )
			{
				buildWall(hit.point);
			}
		}
	}

	void buildWall(Vector3 buildPos)
	{
		transform.parent.GetComponent<Score>().BuildBlocks --;
		Instantiate(wall, buildPos, wall.transform.rotation);

	}



	
}
