using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;
using System;

public class NewGameTwo : MonoBehaviour {



	void OnMouseDown(){
		transform.localScale *= 0.8f;
		NewGame.onePlayer = false;
	}

	void OnMouseUp(){
		SceneManager.LoadScene ("Game");
		NewGame.banner.Hide ();

	}

	void Start(){
		GooglePlayGame.Init ();
		GooglePlayGame.Login((bool success) => {
		});
	}
}
