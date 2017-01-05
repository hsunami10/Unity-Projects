using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	private int left, right;
	private KeyCode leftKey, rightKey;
	private Ball ball;
	public static float speed;
	public bool autoPlay = false;

	void Awake() {

		// Initialize KeyCodes
		left = PlayerPrefs.GetInt ("block-breaker-left-control");
		right = PlayerPrefs.GetInt ("block-breaker-right-control");
		leftKey = (KeyCode)left;
		rightKey = (KeyCode)right;

		gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		speed = 0.16f;
	}

	void Start() {
		ball = GameObject.FindObjectOfType<Ball> ();
	}

	// Can use Mathf.Clamp(value, min, max)
	void AutoPlay() {
		// Set x position of paddle equal to the x position of the ball
		Vector3 paddlePos = this.transform.position;
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = ballPos.x;
		this.transform.position = paddlePos;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag.Contains ("Power"))
			Destroy (other.gameObject);
	}

	// Update is called once per frame
	void Update () {

		if (autoPlay)
			AutoPlay ();
		
		// Get current position, change it, then set current position to altered position
		if(Input.GetKey(leftKey)) {
			Vector2 position = this.transform.position;
			position.x = position.x - speed;
			this.transform.position = position;
		}
		if(Input.GetKey(rightKey)) {
			Vector2 position = this.transform.position;
			position.x = position.x + speed;
			this.transform.position = position;
		}

		// Restrict paddle movement to boundaries
		if(gameObject.transform.position.x <= 1.25f) {
			Vector3 position = this.transform.position;
			position.x = 1.22f;
			this.transform.position = position;
		}
		if(gameObject.transform.position.x >= 14.67f) {
			Vector3 position = this.transform.position;
			position.x = 14.67f;
			this.transform.position = position;
		}

		// Paused menu
		if (PlayerPrefs.GetString ("block-breaker-paused") == "true")
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		else
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
	}
}
