using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	public TextMesh enemy;
	public TextMesh ball;
	public TextMesh maxScore;

	void OnMouseDown(){
		transform.localScale *= 0.8f;
	}

	void OnMouseUp(){
		Ball.speed = 15;
		Enemy.speed = 7.5f;
		Score.end = 5;
		ball.text = "" + Ball.speed;
		enemy.text = "" + Enemy.speed;
		maxScore.text = "" + Score.end;
		transform.localScale /= 0.8f;
	}
}
