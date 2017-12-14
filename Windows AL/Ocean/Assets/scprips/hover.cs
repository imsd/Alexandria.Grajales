using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;



public class hover : MonoBehaviour {


	public GameObject Pic1;
	public VideoPlayer Vid1;
	public string HoverText;
	public TextMesh DisplayTextObject;

	void Start(){DisplayTextObject.color = new Color(0,0,0,0);}
	void OnMouseEnter() {
		// switch the 3d text so that its text value
		// is now whatever text value this hover instance holds
		DisplayTextObject.text = HoverText;

		// show it
		DisplayTextObject.color = Color.white;

		// video sectopn
		if (Vid1 != null) {
			Vid1.gameObject.SetActive (true);
			Vid1.Play ();
		}
			if (Pic1 != null) {
				Pic1.gameObject.SetActive (true);

		
		}

}


	void OnMouseExit() {
		DisplayTextObject.color = new Color(0,0,0,0);

		// video section
		Vid1.gameObject.SetActive (false);
		Vid1.Stop ();


		Pic1.gameObject.SetActive (false);

	

	}
}


