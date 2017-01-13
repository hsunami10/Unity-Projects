using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script that controls bouncing physics and detection for all players
/// </summary>
public class BallController : MonoBehaviour {

	Rigidbody2D myRigidBody2D;

	// Use this for initialization
	void Start () {
		myRigidBody2D = gameObject.GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D(Collision2D other) {
		
		// If have the same tag (Player)
		if(other.gameObject.CompareTag(gameObject.tag)) {
			Vector2 vel = other.gameObject.GetComponent<Rigidbody2D> ().velocity;
			float mass = other.gameObject.GetComponent<Rigidbody2D> ().mass;
			myRigidBody2D.AddForce(other.contacts[0].normal * vel.magnitude * mass, ForceMode2D.Force);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		
	}

	// Before every physics action
	void FixedUpdate() {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Restrict movement to inside the screen
/*		Vector3 position = gameObject.transform.position;
		position.x = Mathf.Clamp (transform.position.x, -8.534f, 8.524f);
		position.y = Mathf.Clamp (transform.position.y, -4.635f, 4.635f);
		transform.position = position;*/
	}
}
