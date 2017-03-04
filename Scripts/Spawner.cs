using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	float randX, randY;
	public GameObject ball;

	void Start () {
		
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Spawn ();
		}
	}

	void Spawn(){
		randY = Random.Range (-4.3f, 4.3f);
		randX = Random.Range (-8.0f, 8.0f);
		Instantiate (ball, new Vector3 (randX, randY, 0), Quaternion.identity);
	}
}
