using UnityEngine;
using System.Collections;

public class projectileCAC : MonoBehaviour {

	public ParticleSystem fire;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Fire2")) 
		{
			Instantiate (fire);///faire un délai de temps, une limite à 1 et prendre les positions de la torche etc. = pas fini
		}
			
	
	}
}
