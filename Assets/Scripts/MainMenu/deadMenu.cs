using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class deadMenu : MonoBehaviour {


	public void Restart()
	{
		HealthBar.isDead = false;
		HealthBar.cur_health = 10;
		SceneManager.LoadScene ("Level1");

	}
}
