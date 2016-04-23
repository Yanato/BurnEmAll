using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

	// Use this for initializationj
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void StartGame() {
		SceneManager.LoadScene ("Level1");

	}
	public void Exit (){
		Application.Quit();

	}

	public void Option(){
	}

	public void Credit(){
	}
	public void Continue(){
	}
}
