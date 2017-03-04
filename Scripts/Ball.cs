using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Ball : MonoBehaviour {


	Rigidbody rb;
	bool isPlay;
	int randInt;
	AudioSource audioSource;
	public static float speed = 15;
	public static float speedWall = 10;

	void Awake () {
		rb = gameObject.GetComponent<Rigidbody> ();

		randInt = Random.Range (1, 3);
		audioSource = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		for(int i = 0; i < Input.touchCount; i++){
			if (Input.GetTouch (i).phase == TouchPhase.Began && isPlay == false && Input.GetTouch (i).position.x < 201 && Score.scorePlayer != Score.end && ScoreEnemy.scoreEnemy != Score.end) {
				if (WallScore.isWall == false) {
					audioSource.Play ();
					transform.parent = null;
					isPlay = true;
					rb.isKinematic = false;
					NewGame.banner.Hide ();
					if (randInt == 1) {
						rb.velocity = new Vector3 (speed, 10, 0);
					}
					if (randInt == 2) {
						rb.velocity = new Vector3 (speed, -10, 0);
					}
				}
				if (WallScore.isWall == true) {
					audioSource.Play ();
					transform.parent = null;
					isPlay = true;
					rb.isKinematic = false;
					NewGame.banner.Hide ();
					if (randInt == 1) {
						rb.velocity = new Vector3 (speedWall, speedWall, 0);
					}
					if (randInt == 2) {
						rb.velocity = new Vector3 (speedWall, -speedWall, 0);
					}
				}

			}

		}
	}


}
