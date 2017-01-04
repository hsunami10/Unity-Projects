using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// End the game using triggers
/// </summary>
public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void Awake() {
		// AUtomatically link LevelManager and LoseCollider
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	// Called when at least one of the bodies are triggers
	void OnTriggerEnter2D(Collider2D trigger) {
		if(trigger.tag == "Ball")
			levelManager.LoadLevel ("Lose");
		if (trigger.tag == "Power Up" || trigger.tag == "Power Down")
			Destroy (trigger.gameObject);
	}

	// Called when all bodies are colliders
	void OnCollisionEnter2D(Collision2D collision) {
		
	}
}
