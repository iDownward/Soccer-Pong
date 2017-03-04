using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Restart : MonoBehaviour {

	public TextMesh winner;
	public static bool restart = false;
	public GameObject ballPref;
	public Transform padleObj;
	Rigidbody rbBall;
	GameObject ball;

	void Start(){
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		gameObject.GetComponent<SphereCollider> ().enabled = false;
		rbBall = ballPref.GetComponent<Rigidbody> ();
	}

	void OnMouseDown(){
		transform.localScale *= 0.8f;
	}

	void OnMouseUp(){
		transform.localScale /= 0.8f;
		if (WallScore.isWall == false) {
			
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;

			restart = true;
			gameObject.GetComponent<SphereCollider> ().enabled = false;
			Score.scorePlayer = 0;
			ScoreEnemy.scoreEnemy = 0;
			winner.text = "";
			NewGame.banner.Hide ();
		} else {
			
			WallScore.score = 0;
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			gameObject.GetComponent<SphereCollider> ().enabled = false;
			(Instantiate (ballPref, new Vector3 (padleObj.transform.position.x + 2, padleObj.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = padleObj;
			rbBall = ballPref.GetComponent<Rigidbody> ();
			NewGame.banner.Hide ();
		}
	}
}
