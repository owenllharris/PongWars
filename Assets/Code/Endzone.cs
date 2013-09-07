using UnityEngine;
using System.Collections;

public class Endzone : MonoBehaviour {

	void OnTriggerEnter(Collider enterer)
	{
		if(enterer.tag == "Puk")
		{
			enterer.transform.parent.GetComponent<Score>().IncreaseScore();
			Destroy(enterer.gameObject);
		}
	}
}
