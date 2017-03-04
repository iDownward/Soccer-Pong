using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallMode : MonoBehaviour {



	void OnMouseDown(){
		transform.localScale *= 0.8f;
	}

	void OnMouseUp(){
		SceneManager.LoadScene ("Wall");
		WallScore.isWall = true;
		NewGame.banner.Hide ();
	}
}
