using UnityEngine;
using System.Collections;

public class HealthV2 : MonoBehaviour
{
	public float hp = 1;
	public float ashes = 0.01f;
	GameObject Smoke;

	public GameObject decore;
	private Transform decor;

	private float r = 1;
	private float g = 1;
	private float b = 1;

	void Start() 
	{
		Smoke = Resources.Load("WhiteSmoke") as GameObject;
		decor = decore.transform;
	}

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
		r = r - ashes;
		g = g - ashes;
		b = b - ashes;

		if (r <= 0.41f && r>= 0.40f) {
			GameObject fumee = Instantiate (Smoke) as GameObject;
			fumee.transform.parent = decor;
			fumee.transform.position = decor.transform.position;
		}

		GetComponent<SpriteRenderer>().color = new Color (r, g, b, 1);

		if (hp <= 0)
		{
			Destroy(gameObject);
		}
	}
}