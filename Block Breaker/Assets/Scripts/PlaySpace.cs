using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySpace : MonoBehaviour {

	void Start() {
		gameObject.GetComponent<SpriteRenderer> ().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {

		// Hide background and walls if the game is paused
		if (PlayerPrefs.GetString ("block-breaker-paused") == "true") {
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		}
		else {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}
