using UnityEngine;
using System.Collections;

public class DuFEU : MonoBehaviour
{
    GameObject Fire;
    void Start() {
        Fire = Resources.Load("Fire torche") as GameObject;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {

		if ((coll.collider == true)&& (coll.gameObject.tag != "nop"))
        {
            GameObject Feu = Instantiate(Fire) as GameObject;
			Feu.transform.parent = coll.transform;
			Feu.transform.position = coll.transform.position;
        }
		if (coll.gameObject.tag == "nop") {
			Destroy (gameObject);

			}


	}
}
