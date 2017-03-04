using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScore : MonoBehaviour {

	GameObject ball;
	public static int score = 0;
	public TextMesh scoreText;

	public static bool isWall = false;

	void Awake() {
		ball = GameObject.FindGameObjectWithTag ("ball");
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "" + score;
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "ball") {
			score += 1;
			if (Ball.speedWall < 27) {
				Ball.speedWall += 1;
			}
		}
	}
}
