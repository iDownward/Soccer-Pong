using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour {


	void OnMouseDown(){
		transform.localScale *= 0.8f;
	}

	void OnMouseUp(){
		SceneManager.LoadScene ("Menu");
		WallScore.isWall = false;
		WallScore.score = 0;
		Ball.speedWall = 10;
		Score.scorePlayer = 0;
		ScoreEnemy.scoreEnemy = 0;
		NewGame.banner.Hide ();
	}
}
