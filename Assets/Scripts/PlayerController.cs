
/// <summary>
/// Player controller.
/// mouvement personnage 
/// double jump
/// définition plateforme
/// </summary>


using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	public Transform groundVerification;
	public float groundVerificationRadius;
	public LayerMask groundWhat;
	private bool grounded;

	public bool doubleJumped;

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate() 
	{
		grounded = Physics2D.OverlapCircle (groundVerification.position, groundVerificationRadius, groundWhat);

	}
	
	// Update is called once per frame
	void Update () {
		if (grounded)
			doubleJumped = false;

		if (Input.GetKeyDown (KeyCode.Z) && grounded) 
		{
			Jump();
		}

		if (Input.GetKeyDown (KeyCode.Z) && !doubleJumped && !grounded) 
		{
			Jump();
			doubleJumped = true;
		}

		if (Input.GetKey (KeyCode.Q)) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
	
	}


	public void Jump()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}