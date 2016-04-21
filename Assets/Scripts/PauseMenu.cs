using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

	public bool isPause = false;
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


		if (isPause || HealthBar.isDead)
		{
			Time.timeScale = 0;
            Debug.Log("tibo");
		}else{
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
	