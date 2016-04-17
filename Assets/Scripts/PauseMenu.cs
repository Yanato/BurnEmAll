using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

	bool isPause = false;
	public GameObject menu;

	void start ()
	{
		menu.SetActive(false);

	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			isPause = !isPause;
		}


		if (isPause)
		{
			Time.timeScale = 0;
		}else{
			Time.timeScale = 1;
		}

		if (HealthBar.isDead) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}

	}

	void OnGUI()
	{
		if (isPause) {
			menu.SetActive (true);

		} else {
			menu.SetActive (false);
		}
	}

	public void Resume ()
	{
		isPause = false;
	}
}
	