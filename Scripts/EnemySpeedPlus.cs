using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpeedPlus : MonoBehaviour {

	public TextMesh textSpeed;

	void Awake () {
		textSpeed.text = "" + Enemy.speed;
	}

	// Update is called once per frame
	void OnMouseDown() {
		Enemy.speed += 0.5f;
		textSpeed.text = "" + Enemy.speed;
		NewGame.banner.Hide ();
	}

	void Update (){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
