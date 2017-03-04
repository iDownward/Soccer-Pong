using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeedMinus : MonoBehaviour {

	public TextMesh textSpeed;

	// Update is called once per frame
	void OnMouseDown() {
		Enemy.speed -= 0.5f;
		textSpeed.text = "" + Enemy.speed;
		NewGame.banner.Hide ();
	}
}
