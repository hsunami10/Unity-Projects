using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// End the game using triggers
/// </summary>
public class LoseCollider : MonoBehaviour {

	// Instantiate Level Manager game object
	public LevelManager levelManager;

	// Called when at least one of the bodies are triggers
	void OnTriggerEnter2D(Collider2D trigger) {
		levelManager.LoadLevel ("Lose");
	}

	// Called when all bodies are colliders
	void OnCollisionEnter2D(Collision2D collision) {
		
	}
}
