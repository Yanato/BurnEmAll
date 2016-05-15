using UnityEngine;
using System.Collections;

public class NoCollisionBetween : MonoBehaviour {

	public GameObject Player;
	public GameObject LaPlatform;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		LaPlatform = GameObject.Find ("LaPlatform");
		Physics2D.IgnoreCollision (gameObject.transform.GetComponent<Collider2D> (), Player.transform.GetComponent<Collider2D> ());
		Physics2D.IgnoreCollision (gameObject.transform.GetComponent<Collider2D> (), LaPlatform.transform.GetComponent<Collider2D> ());

	}
	
	// Update is called once per frame
	void Update () {


	}
}
