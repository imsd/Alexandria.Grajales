using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	
	public float Power = 200f;


	void Update () {
		if(Input.GetKeyUp("space")){
			Vector3 Jump = Vector3.up * Power;
			GetComponent<Rigidbody> ().AddForce (Jump);
		}
}
}