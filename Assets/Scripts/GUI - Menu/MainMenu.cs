using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public static bool DisableContinue = true;
	public Transform continuelife;
	public static bool checkpointe=false;

	public static bool isIntro = true;

	public GameObject options;
	public GameObject mainmenu;
	public GameObject allmenu;
	public GameObject menuSound;
	public GameObject credits;

	public Slider mainSlider;
	public static float volume;

	public static bool isFrench;
	// Use this for initializationj

	void Start (){
		menuSound.SetActive (true);

		mainSlider = GameObject.Find ("Slider").GetComponent<Slider>();
		credits.SetActive (false);
		isFrench = false;
	}

	// Update is called once per frame
	void Update () {
		volume = mainSlider.value;
		if (DisableContinue == true) {
				continuelife.GetComponent<Button>().interactable = false; 
			}else
			{
				continuelife.GetComponent<Button>().interactable = true;
			}

	}

	public void French(){
		isFrench = true;
	}	
	public void English(){
		isFrench = false;
	}


	public  void StartGame() {

		DisableContinue = false;

		if (isIntro == true) {
			SceneManager.LoadScene ("intro");
		} else {
			DisableContinue = false;
			SceneManager.LoadScene ("Level1");
			HealthBar.cur_health = 100;
			HealthBar.life = 3;
		}
	}

	public void Continue(){
		
		SceneManager.LoadScene ("Level1");
		HealthBar.cur_health = 100;
		checkpointe = true;
	}




	public void Credit(){
		credits.SetActive (true);
		allmenu.SetActive (false);
		menuSound.SetActive (false);

	}

	public void ReturnMenu()
	{
		credits.SetActive (false);
		allmenu.SetActive (true);

	}
	public void ReturnMenuCredit()
	{
		credits.SetActive (false);
		allmenu.SetActive (true);
		menuSound.SetActive (true);

	}


	public void Option(){
		options.SetActive(true);
		mainmenu.SetActive(false);
	}

	public void Exit (){
		Application.Quit();

	}

}
