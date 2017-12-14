using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerController : MonoBehaviour {


	private Rigidbody rb;
	public float speed;
	private float turboSpeed=0.1f;
	public float myvariable;




	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();


	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		float MoveHorizontal = Input.GetAxis ("Horizontal"); // listen to key strokes and assign it to the variable
		float MoveVertical = Input.GetAxis ("Vertical"); // listen to key strokes and assign it to the variable


		Vector3 movement = new Vector3 (MoveHorizontal, 0.0f, MoveVertical);
		GetComponent<Rigidbody> ().AddForce (movement * speed * turboSpeed * Time.deltaTime);

		// JUMP:

		if (Input.GetKeyDown("return")){

			turboSpeed = 40f;} 
			else
			{turboSpeed = 0.1f;}
	
			
			if (Input.GetKeyDown ("space") && GetComponent<Rigidbody> ().transform.position.y <= 0.625f) {

				Vector3 jump = new Vector3 (0.0f, 100f, 0.0f);
				GetComponent<Rigidbody> ().AddForce (jump);
			}



			rb.AddForce (movement * speed * turboSpeed);


		}
	}


	
