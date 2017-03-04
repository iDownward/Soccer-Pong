using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBall : MonoBehaviour {

	public int speed = 500;
	public Rigidbody rb;

	void Awake(){
		rb.velocity = new Vector3 (speed, speed, 0);
	}	
}
