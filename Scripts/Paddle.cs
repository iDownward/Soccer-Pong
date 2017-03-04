using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paddle : MonoBehaviour {

	public Vector2 playerPos;
	public float speed;
	public float maximoY, minimoY;
	AudioSource audioSource;
	GameObject ball;
	Rigidbody rbBall;


	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
		ball = GameObject.FindGameObjectWithTag ("ball");
		rbBall = ball.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

		if (NewGame.onePlayer) {
			ball = GameObject.FindGameObjectWithTag ("ball");
			rbBall = ball.GetComponent<Rigidbody> ();
			for (int i = 0; i < Input.touchCount; i++) {
				if(Input.touchCount > i && Input.GetTouch(i).phase == TouchPhase.Moved && Input.GetTouch(i).position.x < 293){
					Vector2 touchDeltaPosition = Input.GetTouch(i).deltaPosition;
					transform.Translate(0, Mathf.Clamp(touchDeltaPosition.y * 0.057f, -5.3f, 5.3f), 0);
					Vector2 playerPos = new Vector2 (transform.position.x, transform.position.y);
					if (playerPos.y > 5.3f) {
						gameObject.transform.position = new Vector2 (transform.position.x, 5.4f);
						Debug.Log (transform.position.y);
					}
					if (playerPos.y < -5.4f) {
						gameObject.transform.position = new Vector2 (transform.position.x, -5.4f);
					}
				}
			}
		} else {
			ball = GameObject.FindGameObjectWithTag ("ball");
			rbBall = ball.GetComponent<Rigidbody> ();
			for (int i = 0; i < Input.touchCount; i++) {
				if(Input.touchCount > i && Input.GetTouch(i).phase == TouchPhase.Moved && Input.GetTouch(i).position.x < 293){
					Vector2 touchDeltaPosition = Input.GetTouch (i).deltaPosition;
					transform.Translate(0, Mathf.Clamp(touchDeltaPosition.y * 0.057f, -5.3f, 5.3f), 0);
					Vector2 playerPos = new Vector2 (transform.position.x, transform.position.y);
					if (playerPos.y > 5.3f) {
						gameObject.transform.position = new Vector2 (transform.position.x, 5.4f);
						Debug.Log (transform.position.y);
					}
					if (playerPos.y < -5.4f) {
						gameObject.transform.position = new Vector2 (transform.position.x, -5.4f);
					}
				}
			}

		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("Menu");
		}
		
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "ball") {
			audioSource.Play ();
			if (WallScore.isWall == false) {
				rbBall.velocity = new Vector3 (Ball.speed, Random.Range (-22, 22), 0);
				NewGame.banner.Hide ();
			} else {
				rbBall.velocity = new Vector3 (Ball.speedWall, Random.Range (-20, 20), 0);
				NewGame.banner.Hide ();
			}
		}
	}



}
