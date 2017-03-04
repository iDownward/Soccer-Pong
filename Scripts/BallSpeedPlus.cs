using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpeedPlus : MonoBehaviour {

	public TextMesh textSpeed;

	void Awake () {
		textSpeed.text = "" + Ball.speed;
	}
	
	// Update is called once per frame
	void OnMouseDown() {
		if (Ball.speed < 37) {
			Ball.speed += 0.5f;
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
