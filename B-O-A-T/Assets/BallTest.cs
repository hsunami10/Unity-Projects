using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the test ball (before multiplayer implementation)
/// </summary>
public class BallTest : MonoBehaviour {

	Rigidbody2D myRigidBody2D;
	private float force;
	Vector2 forceX, forceY;

	// Use this for initialization
	void Start () {
		force = 0.08f;
		forceX = new Vector2 (force, 0);
		forceY = new Vector2 (0, force);
		myRigidBody2D = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.RightArrow))
			myRigidBody2D.AddForce (forceX, ForceMode2D.Impulse);
		if (Input.GetKey (KeyCode.LeftArrow))
			myRigidBody2D.AddForce (-forceX, ForceMode2D.Impulse);
		if (Input.GetKey (KeyCode.UpArrow))
			myRigidBody2D.AddForce (forceY, ForceMode2D.Impulse);
		if (Input.GetKey (KeyCode.DownArrow))
			myRigidBody2D.AddForce (-forceY, ForceMode2D.Impulse);
	}
}
