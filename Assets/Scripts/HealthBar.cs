using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Image Background;
	public Image Bar;	
	public RectTransform TailleBar;

	public int max_health = 10;
	public int cur_health = 10;	


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