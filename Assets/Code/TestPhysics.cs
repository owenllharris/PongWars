using UnityEngine;
using System.Collections;

public class TestPhysics : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
	}
	

}
