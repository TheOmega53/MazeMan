﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public void Back(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void Quit(){
		Debug.Log ("Quit!");
		Application.Quit ();
	}
}
