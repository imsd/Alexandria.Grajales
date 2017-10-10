using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	public Vector3 myRotation;

	void Update () {
		
		transform.Rotate (myRotation * Time.deltaTime);
	}
}
