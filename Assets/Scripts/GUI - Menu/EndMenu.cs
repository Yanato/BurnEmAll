﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour {
	public static bool restartGame;

	public void Exit () {
		Application.Quit();
	}

	public void credits () {

		SceneManager.LoadScene ("Menu");
		MainMenu.DisableContinue = true;
	}
}
