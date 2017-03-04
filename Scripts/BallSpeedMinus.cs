using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpeedMinus : MonoBehaviour {

	public TextMesh textSpeed;

	// Update is called once per frame
	void OnMouseDown() {
		if (Ball.speed > 0.5f) {
			Ball.speed -= 0.5f;
			textSpeed.text = "" + Ball.speed;
		}
		NewGame.banner.Hide ();
	}

	void Update (){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
