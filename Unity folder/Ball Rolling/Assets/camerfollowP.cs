using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerfollowP : MonoBehaviour {
	public GameObject player; // refrence to sphere 
	private Vector3 offset; 


	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;//distance between camera 
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = player.transform.position + offset; 
	}
}
