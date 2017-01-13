using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the ball movement from tilting
/// </summary>
public class AccelerometerInput : MonoBehaviour {

	Rigidbody2D myRigidBody2D;
	private float xComp, yComp;

	// Use this for initialization
	void Start () {
		myRigidBody2D = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		// Adjust force component according to tilt sensitivity
		xComp = (Input.acceleration.x - PlayerPrefs.GetFloat("reorient x")) / PlayerPrefs.GetFloat("tilt sensitivity");
		yComp = (Input.acceleration.y - PlayerPrefs.GetFloat("reorient y")) / PlayerPrefs.GetFloat("tilt sensitivity");

		// Create force vectors
		Vector2 forceX = new Vector2 (xComp, 0);
		Vector2 forceY = new Vector2 (0, yComp);

		// Apply force in the direction of Vector2
		myRigidBody2D.AddForce (forceX, ForceMode2D.Impulse);
		myRigidBody2D.AddForce (forceY, ForceMode2D.Impulse);
	}
}