using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPlus : MonoBehaviour {

	public TextMesh maxScore;
	Vector2 posInicial;
	Vector2 posFinal;

	void Awake () {
		if (Score.end != 1000) {
			maxScore.text = "" + Score.end;
		} else {
			maxScore.text = "Endless";
		}
		posInicial = new Vector2(-1.1f, transform.position.y);
		posFinal = new Vector2 (2.4f, transform.position.y);
	}
		

	// Update is called once per frame
	void OnMouseDown() {
			
		if (Score.end == 1000) {
			Score.end = 1;
		} else {
			Score.end += 1;
		}
			maxScore.text = "" + Score.end;
		NewGame.banner.Hide ();
		
	}

	void Update (){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("Menu");
		}
		if (Score.end == 1000) {
			gameObject.transform.position = posFinal;
		} else {
			gameObject.transform.position = posInicial;
		}

	}
}
