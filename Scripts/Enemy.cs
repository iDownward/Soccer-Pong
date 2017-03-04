using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	bool isOnePlayer;
	public static float speed = 7.5f;
	Vector3 playerPos;
	GameObject ballObj;
	Vector3 targetPos;
	Rigidbody rbBall;
	AudioSource audioSource;

	Vector3 touchPos;

	void Awake(){
		isOnePlayer = NewGame.onePlayer;
		ballObj = GameObject.FindGameObjectWithTag ("ball");
		rbBall = ballObj.GetComponent<Rigidbody> ();
		audioSource = gameObject.GetComponent<AudioSource> ();

	}

	
	// Update is called once per frame
	void Update () {
		
		if (isOnePlayer == false) {
			ballObj = GameObject.FindGameObjectWithTag ("ball");
			rbBall = ballObj.GetComponent<Rigidbody> ();
			for (int i = 0; i < Input.touchCount; i++) {
				if(Input.touchCount > i && Input.GetTouch(i).phase == TouchPhase.Moved && Input.GetTouch(i).position.x > 293){
					Vector2 touchDeltaPosition = Input.GetTouch(i).deltaPosition;
					transform.Translate(0, Mathf.Clamp(touchDeltaPosition.y * 0.057f, -5.3f, 5.3f), 0);
					Vector2 playerPos = new Vector2 (transform.position.x, transform.position.y);
					if (playerPos.y > 5.4f) {
						gameObject.transform.position = new Vector2 (transform.position.x, 5.4f);
					}
					if (playerPos.y < -5.4f) {
						gameObject.transform.position = new Vector2 (transform.position.x, -5.4f);
					}
				}
			}

		}


		  else {
			ballObj = GameObject.FindGameObjectWithTag ("ball");
			rbBall = ballObj.GetComponent<Rigidbody> ();
			if (ballObj != null) {
				targetPos = Vector3.Lerp (gameObject.transform.position, ballObj.transform.position, Time.deltaTime * speed);
				playerPos = new Vector3 (transform.position.x, Mathf.Clamp (targetPos.y, -5.3f, 5.3f), 0);
				gameObject.transform.position = new Vector3 (transform.position.x, playerPos.y, transform.position.z);
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "ball") {
			rbBall.velocity = new Vector3(-Ball.speed, Random.Range(-20, 20), 0);
			audioSource.Play ();
			NewGame.banner.Hide ();
		}
	}
}
