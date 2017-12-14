
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollowQ : MonoBehaviour {
	public GameObject sphere; // refrence to sphere 
	private Vector3 offset; 


	// Use this for initialization
	void Start () {
		offset = transform.position - sphere.transform.position;//distance between camera 
	}

	// Update is called once per frame
	void Update () {

		transform.position = sphere.transform.position + offset; 
	}
}
