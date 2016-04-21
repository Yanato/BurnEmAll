using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthBar : MonoBehaviour
{
	public Image Background;
	public Image Bar;	
	public RectTransform TailleBar;

	public int max_health = 10;
	public static int cur_health = 10;
	public static int life = 3;

	public static bool isDead = false;
	public GameObject deadMenu;
	int i = 0;


	void start ()
	{
		deadMenu.SetActive(false);
	}

	void Update()
	{
		if (cur_health == 0) {
			HealthBar.cur_health = 10;
			SceneManager.LoadScene ("Level1");
			life--;

		}
		if (life == 0) {
			Transform character = gameObject.GetComponent<Transform>();
			character.rotation = Quaternion.Euler (0, 0, 90);
			i++;
			if (i > 50) {
				isDead = true;
			}
		}


	}

	void OnGUI()
	{
		if (isDead) {
			deadMenu.SetActive (true);

		} else {
			deadMenu.SetActive (false);
		}
	}


	void OnCollisionEnter2D(Collision2D collision)
	{
		
		if (collision.gameObject.tag == "rabbit") {
			if (cur_health > 0) {
				cur_health -= 1;
				UpdateHealthBar (cur_health);
			}
		}
		if (collision.gameObject.tag == "flower") 
		{
			if (cur_health > 0) {
				cur_health -= 5;
				UpdateHealthBar (cur_health);
			}
				
		}
	}



	public void UpdateHealthBar ( float cur_health)
	{
		Bar.fillAmount = cur_health / max_health;
		TailleBar.sizeDelta = new Vector2 (390 * Bar.fillAmount, 25);

	}
			
} 