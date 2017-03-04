using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {


	void OnMouseDown(){
		transform.localScale *= 0.8f;
	}
	void OnMouseUp(){
		Application.Quit ();
	}
}
