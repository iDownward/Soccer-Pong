using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMinus : MonoBehaviour {

	public TextMesh maxScore;
	public TextMesh plus;
	Vector2 posInicial;
	Vector2 posFinal;

	void Awake(){
		posInicial = new Vector2 (-1.0f, transform.position.y);
		posFinal = new Vector2 (2.5f, transform.position.y);
	}

	// Update is called once per frame
	void OnMouseDown() {
		
		if (Score.end > 0 && Score.end < 999) {
			if (Score.end == 1) {
			
				Score.end = 1000;

				maxScore.text = "Endless";
			} else {
				Score.end -= 1;
			
				maxScore.text = "" + Score.end;
			}
		}
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
