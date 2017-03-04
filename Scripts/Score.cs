using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;

public class Score : MonoBehaviour {

	public TextMesh playerSco;
	public TextMesh winner;

	public Transform padleObj;
	Rigidbody rbBall;
	AudioSource audioSource;

	public static int end = 5;
	public static int scorePlayer = 0;

	GameObject ball;
	public GameObject ballPref;
	GameObject restart;

	Vector2 posOne;
	Vector2 posTwo;

	static InterstitialAd interstital;


	void Start(){
		winner.GetComponent<MeshRenderer> ().enabled = false;
		restart = GameObject.FindGameObjectWithTag ("btnRestart");
		posOne = new Vector2 (-3.7f, winner.transform.position.y);
		posTwo = new Vector2 (-6.4f, winner.transform.position.y);
		RequestInterstitial ();
	}

	// Update is called once per frame
	void Update () {
		
			ball = GameObject.FindGameObjectWithTag ("ball");
			audioSource = gameObject.GetComponent<AudioSource> ();

		
		playerSco.text = "" + scorePlayer;
		if (scorePlayer == end) {
			winner.GetComponent<MeshRenderer> ().enabled = true;

			restart.GetComponent<SpriteRenderer> ().enabled = true;
			restart.GetComponent<SphereCollider> ().enabled = true;

		}

	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "ball") {
			audioSource.Play ();
			scorePlayer += 1;
			Destroy (ball);
			(Instantiate (ballPref, new Vector3 (padleObj.transform.position.x + 2, padleObj.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = padleObj;
			if (scorePlayer == end) {
				if (NewGame.onePlayer) {
					winner.transform.position = posOne;
					winner.text = "Victory!";
					NewGame.RequestBanner ();
					showAd ();

				} else {
					winner.transform.position = posTwo;
					winner.text = "Player 1 wins!";
					NewGame.RequestBanner ();
					showAd ();
				}
			}
		}
	}

	public static void RequestInterstitial(){
		interstital = new InterstitialAd ("ca-app-pub-1541045839364233/6856407301");
		AdRequest adRequest = new AdRequest.Builder().Build();
		interstital.LoadAd (adRequest);
	}

	public static void showAd()
	{
		if (interstital.IsLoaded ()) {
			interstital.Show ();
		}
	}
}
