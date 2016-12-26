using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Get access to the paddle
	public Paddle paddle;
	private Vector3 paddleToBallVector, randomVec;
	int randDeg;
	float randRad, x, y, magnitude;
	private bool hasStarted = false;

	// Use this for initialization
	void Start () {

		// Take difference in position
		paddleToBallVector = this.transform.position - paddle.transform.position;
		magnitude = 9;
	}
	
	// Update is called once per frame
	void Update () {

		// Doesn't run through this code once the space button is pressed -> sets velocity once
		if (!hasStarted) {
			
			// Set initial position
			this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetKeyDown (KeyCode.Space)) {

				// Create a random angle between 45-135 degrees
				randDeg = (int)(Random.value*90 + 45);
				randRad = randDeg * Mathf.Deg2Rad;
				x = Mathf.Cos (randRad);
				y = Mathf.Sin (randRad);
				randomVec = new Vector2 (x, y);

				// Access the rigidbody2D component of the ball class
				gameObject.GetComponent<Rigidbody2D>().velocity = randomVec * magnitude;
				hasStarted = true;
			}
		}
	}
}
