using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 paddleToBallVector, randomVec;
	private int randDeg;
	private float randRad, x, y;
	public static float magnitude;
	private static bool hasStarted = false;

	// Array of different audio sources
	public AudioSource[] audio = new AudioSource[3];

	// Use this for initialization
	void Start () {

		// Automatically get access to paddle
		paddle = GameObject.FindObjectOfType<Paddle>();

		// Take difference in position
		paddleToBallVector = this.transform.position - paddle.transform.position;
		magnitude = 9;
		hasStarted = false;

		gameObject.GetComponent<SpriteRenderer> ().enabled = true;
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

		// Paused menu
		if (PlayerPrefs.GetString ("block-breaker-paused") == "true") {
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		}
		else {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}

	// Play different sounds on differnt collisions
	void OnCollisionEnter2D(Collision2D collision) {

		if (collision.gameObject.name == "Paddle")
			audio [0].Play ();
		else if (collision.gameObject.name.Contains ("block"))
			audio [1].Play ();
		else if (collision.gameObject.name.Contains ("Wall"))
			audio [2].Play ();
	}
}
