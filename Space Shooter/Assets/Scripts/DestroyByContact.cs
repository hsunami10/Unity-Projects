using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	// Reference explosion VFXs
	public GameObject explosion;
	public GameObject playerExplosion;

	// Destroy the game object when the other collider (laser) enters the volume of the asteroid
	void OnTriggerEnter(Collider other) {

		// If the tag is boundary, then exit the function
		if (other.tag == "Boundary")
			return;

		// Create an explosion at the same position and rotation as the asteroid/player
		Instantiate (explosion, this.transform.position, this.transform.rotation);

		if(other.tag == "Player")
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);

		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
