using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour {

	private Rigidbody rb;
	public float speed; 
	public float myvariable;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float MoveHorizontal = Input.GetAxis ("Horizontal");//listens to the key and moves it via the variable (Horizontal/Vertical (16/17)) 
		float MoveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (MoveHorizontal, 0.0f, MoveVertical);

		rb.AddForce(movement * speed); 
			}
}
