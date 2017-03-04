using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour {

	GameObject messageBox;
	BoxCollider bcBox;
	SpriteRenderer srBox;

	void Start(){
		messageBox = GameObject.FindGameObjectWithTag ("box");
		bcBox = messageBox.GetComponent<BoxCollider> ();
		srBox = messageBox.GetComponent<SpriteRenderer> ();
	}

	void OnMouseDown(){
		transform.localScale *= 0.8f;
	}

	void OnMouseUp(){
		transform.localScale /= 0.8f;
		bcBox.enabled = true;
		srBox.enabled = true;
	}
}
