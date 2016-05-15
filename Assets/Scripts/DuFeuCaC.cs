using UnityEngine;
using System.Collections;

public class DuFeuCaC : MonoBehaviour {

	GameObject Fire;
	// Use this for initialization
	void Start () {
		Fire = Resources.Load("Fire torche") as GameObject;

	}
	
	void OnParticleCollision(GameObject other)
	{
		if ((other.gameObject.tag != "Player") && (other.gameObject.tag != "nop") ) {
			GameObject Feu = Instantiate (Fire) as GameObject;
			Feu.transform.parent = other.transform;
			Feu.transform.position = other.transform.position;
		}
	}
}
