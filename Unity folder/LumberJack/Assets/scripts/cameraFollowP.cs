using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowP : MonoBehaviour {

	public GameObject player; // the reference to our player
	private Vector3 offset;


	// Use this for initialization
	void Start () {


		offset = transform.position - player.transform.position; //distance between camera and player
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = player.transform.position + offset; // update new camera position keeping distance

	}
}
