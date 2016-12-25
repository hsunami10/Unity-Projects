using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	int left, right;
	KeyCode leftKey, rightKey;

	void Awake() {

		// Initialize KeyCodes
		left = PlayerPrefs.GetInt ("block-breaker-left-control");
		right = PlayerPrefs.GetInt ("block-breaker-right-control");
		leftKey = (KeyCode)left;
		rightKey = (KeyCode)right;
	}
	// Update is called once per frame
	void Update () {

		// Get current position, change it, then set current position to altered position
		if(Input.GetKey(leftKey)) {
			Vector2 position = this.transform.position;
			position.x = position.x - (float).1;
			this.transform.position = position;
		}
		if(Input.GetKey(rightKey)) {
			Vector2 position = this.transform.position;
			position.x = position.x + (float).1;
			this.transform.position = position;
		}
	}
}
