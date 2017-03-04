using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leadboards : MonoBehaviour {

	void OnMouseDown(){
		transform.localScale *= 0.8f;
		NewGame.onePlayer = false;
	}

	void OnMouseUp(){
		GooglePlayGame.ShowLeadboards ();
		transform.localScale /= 0.8f;
	}
}
