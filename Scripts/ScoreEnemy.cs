using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreEnemy : MonoBehaviour {
	public TextMesh enemySco;
	public TextMesh winner;
	public GameObject ballPref;
	public Transform padleObj;
	Rigidbody rbBall;
	AudioSource audioSource;
	GameObject ball;
	GameObject restart;
	public static int scoreEnemy = 0;
	Vector2 posOne;
	Vector2 posTwo;

	void Start(){
		winner.GetComponent<MeshRenderer> ().enabled = false;
		restart = GameObject.FindGameObjectWithTag ("btnRestart");
		posOne = new Vector2 (-11, winner.transform.position.y);
		posTwo = new Vector2 (-6.4f, winner.transform.position.y);
		Score.RequestInterstitial ();
	}

	// Update is called once per frame
	void Update () {

		ball = GameObject.FindGameObjectWithTag ("ball");
		audioSource = gameObject.GetComponent<AudioSource> ();


		enemySco.text = "" + scoreEnemy;
		if (scoreEnemy == Score.end) {
			winner.GetComponent<MeshRenderer> ().enabled = true;

			restart.GetComponent<SpriteRenderer> ().enabled = true;
			restart.GetComponent<SphereCollider> ().enabled = true;
		}

	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "ball") {
			audioSource.Play ();
			scoreEnemy += 1;
			Destroy (ball);
			(Instantiate (ballPref, new Vector3 (padleObj.transform.position.x + 2, padleObj.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = padleObj;
			if (scoreEnemy == Score.end) {
				if (NewGame.onePlayer) {
					winner.transform.position = posOne;
					winner.text = "You have been defeated";
					NewGame.RequestBanner ();
					Score.showAd ();
				} else {
					winner.transform.position = posTwo;
					winner.text = "Player 2 wins!";
					NewGame.RequestBanner ();
					Score.showAd ();
				}
			}
		}
	}
}
