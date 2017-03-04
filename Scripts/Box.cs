using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

	BoxCollider bc;
	SpriteRenderer sr;

	void Start(){
		bc = gameObject.GetComponent<BoxCollider> ();
		sr = gameObject.GetComponent <SpriteRenderer> ();
		bc.enabled = false;
		sr.enabled = false;
	}

	void OnMouseDown(){
		bc.enabled = false;
		sr.enabled = false;
	}
}
