using UnityEngine;
using System.Collections;


public class RegenLife : MonoBehaviour {

	Vector3 pos;
	int i = 0;
    void OnTriggerEnter2D(Collider2D coll)
    {
		if (coll.gameObject.name == "Player") {
			if (HealthBar.cur_health < 90) {
				HealthBar.cur_health = HealthBar.cur_health + 10;

			} else {
				HealthBar.cur_health = 100;
			}

			Destroy (gameObject);
		}
		if (i != 1) {
			if (coll.gameObject.tag == "Ground") {
				pos = gameObject.transform.position;
				i = 1;
			}
		}
	}
	void Update()
	{
		if (i == 1) {
			gameObject.transform.position = pos;
		}
	}
}
