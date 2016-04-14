using UnityEngine;
using System.Collections;

public class HealthV2 : MonoBehaviour
{
	public float hp = 1;

	void OnCollisionEnter2D(Collision2D collider)
	{
		Disparation bullet = collider.gameObject.GetComponent<Disparation>();
		if (collider.gameObject.name == "bullet(Clone)")
		{
			hp -= bullet.damage;
		}

		if (hp <= 0)
		{
			Destroy(gameObject);
		}
	}
	void OnParticleCollision(GameObject other)
	{
		hp--;

		if (hp <= 0)
		{
			Destroy(gameObject);
		}
	}
}