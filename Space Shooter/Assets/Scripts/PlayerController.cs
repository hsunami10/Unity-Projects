using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds the boundary values (contraint values) of the ship
/// </summary>
/// Serializing is a way of storing and transferring info -> need to be serialized to view in Inspector
[System.Serializable]
public class Boundary {
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

	public float speed;
	public Boundary boundary;

	// Controls maximum amount of bank
	public float tilt;

	// Update every frame before every physics step - use this for rigidbodies instead of Update()
	void FixedUpdate() {

		// Returns a value between -1, 0, and 1
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		this.GetComponent<Rigidbody> ().velocity = movement * speed;

		// Constrain movement to inside the screen
		this.GetComponent<Rigidbody>().position = new Vector3(
			Mathf.Clamp(this.GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
			0.0f,
			Mathf.Clamp(this.GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax));

		// Tilt the ship when moving according to speed -> Quaternion is used to represent rotations
		this.GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, this.GetComponent<Rigidbody>().velocity.x * -tilt);
	}
}
