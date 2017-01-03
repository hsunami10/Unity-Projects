using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destroys the game object once it exits the boundary
/// </summary>
public class DestroyByBoundary : MonoBehaviour {

	// Runs when the other collider exits the volume of the current game object
	void OnTriggerExit(Collider other) {
		Destroy (other.gameObject);
	}
}
