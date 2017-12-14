using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;



public class hover : MonoBehaviour {


	public GameObject Pic12;
	public GameObject Pic11;
	public GameObject Pic10;
	public GameObject Pic9;
	public GameObject Pic8;
	public GameObject Pic7;
	public GameObject Pic6;
	public GameObject Pic5;
	public GameObject Pic4;
	public GameObject Pic3;
	public GameObject Pic2;
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
		DisplayTextObject.color = Color.black;

		// video sectopn
		if (Vid1 != null) {
			Vid1.gameObject.SetActive (true);
			Vid1.Play ();
		}
			if (Pic1 != null) {
				Pic1.gameObject.SetActive (true);

		}

		if (Pic2 != null) {
			Pic2.gameObject.SetActive (true);

		}

		if (Pic3 != null) {
			Pic3.gameObject.SetActive (true);


		}	

		if (Pic4 != null) {
			Pic4.gameObject.SetActive (true);


		}	 

		if (Pic5 != null) {
			Pic5.gameObject.SetActive (true);


		}	 

		if (Pic6 != null) {
			Pic6.gameObject.SetActive (true);


		}	 

		if (Pic7 != null) {
			Pic7.gameObject.SetActive (true);


		}	 

		if (Pic8 != null) {
			Pic8.gameObject.SetActive (true);


		}	 


		if (Pic9 != null) {
			Pic9.gameObject.SetActive (true);


		}	 

		if (Pic10 != null) {
			Pic10.gameObject.SetActive (true);


		}	 

		if (Pic11 != null) {
			Pic11.gameObject.SetActive (true);


		}	

		if (Pic12 != null) {
			Pic12.gameObject.SetActive (true);


		}	 


}
		
	void OnMouseExit() {
		DisplayTextObject.color = new Color(0,0,0,0);

		// video section
	
		// video sectopn
		if (Vid1 != null) {
			Vid1.gameObject.SetActive (false);
			Vid1.Stop ();
		}


		if (Pic1 != null) {
			Pic1.gameObject.SetActive (false);

		}

		if (Pic2 != null) {
			Pic2.gameObject.SetActive (false);

		}

		if (Pic3 != null) {
			Pic3.gameObject.SetActive (false);


		}



		if (Pic4 != null) {
			Pic4.gameObject.SetActive (false);


		}

		if (Pic5 != null) {
			Pic5.gameObject.SetActive (false);


		}

		if (Pic6 != null) {
			Pic6.gameObject.SetActive (false);


		}



		if (Pic7 != null) {
			Pic7.gameObject.SetActive (false);


		}


		if (Pic8 != null) {
			Pic8.gameObject.SetActive (false);


		}


		if (Pic9 != null) {
			Pic9.gameObject.SetActive (false);


		}

		if (Pic10 != null) {
			Pic10.gameObject.SetActive (false);


		}

		if (Pic11 != null) {
			Pic11.gameObject.SetActive (false);


		}


		if (Pic12 != null) {
			Pic12.gameObject.SetActive (false);


		}


	}
}


