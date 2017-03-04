using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;
using System;

public class WallDeadZone : MonoBehaviour {

	GameObject ball;
	GameObject restart;

	bool adChanger = false;


	void Awake () {
		ball = GameObject.FindGameObjectWithTag ("ball");
		restart = GameObject.FindGameObjectWithTag ("btnRestart");

	}

	void Start(){
		Score.RequestInterstitial ();

	}
	
	// Update is called once per frame
	void Update () {
		ball = GameObject.FindGameObjectWithTag ("ball");
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "ball") {
			Destroy (ball);
			restart.GetComponent<SpriteRenderer> ().enabled = true;
			restart.GetComponent<SphereCollider> ().enabled = true;

			Ball.speedWall = 10;

			if (adChanger) {
				Score.showAd ();
			}
			adChanger = !adChanger;

			GooglePlayGame.ReportScore ("CgkIo6fqmvQaEAIQAQ", WallScore.score, (bool success) => {
			});


		}
	}
}
