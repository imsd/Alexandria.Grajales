using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggertouch : MonoBehaviour {

	private int count; // variable for the score numbe
	public Text countText; // the text object from the UI
	public Text winText; // variable for you win 



	// Use this for initialization
	void Start () {

		count = 0;	// I start count with zero

		winText.text = ""; // start with an empty space

	}
	

	void OnTriggerEnter(Collider other) //listen for the collider of the object that we hit
	{
		if (other.gameObject.CompareTag ("pick up")) { // if the object that we hit has the 'pick up tag'

			other.gameObject.SetActive (false); // then change the active bos to false
			count = count + 1; // increase count by 1 only when i hit the object "pick up"

			countText.text = "Count: " + count.ToString (); // assign new count variable to the UI object

			if( count >= 3) {

			winText.text = " YOU WIN!!! "; // if bigger than 3, send the string to the UI

			}
}
	}
}
