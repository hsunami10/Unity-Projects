using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 paddleToBallVector, randomVec;
	private int randDeg;
	private float randRad, x, y, magnitude;
	public static bool hasStarted = false;

	// Use this for initialization
	void Start () {

		// Automatically get access to paddle
		paddle = GameObject.FindObjectOfType<Paddle>();

		// Take difference in position
		paddleToBallVector = this.transform.position - paddle.transform.position;
		magnitude = 9;
		hasStarted = false;
	}
	
	// Update is called once per frame
	void Update () {

		// Doesn't run through this code once the space button is pressed -> sets velocity once
		if (!hasStarted) {
			
			// Set initial position
			this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetKeyDown (KeyCode.Space)) {

				// Create a random angle between 45-135 degrees
				randDeg = (int)(Random.Range(45f, 135f));
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
