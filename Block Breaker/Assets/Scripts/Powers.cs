using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Script for all power ups and power downs
/// </summary>
/// Multi-ball, sticky ball, change size of paddle
public class Powers : MonoBehaviour {

	public float speed;
	private Paddle paddle;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		InvokeRepeating ("RandColor", 0.0f, 0.3001f);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = this.transform.position;
		move.y -= speed;
		this.transform.position = move;

		// Paused menu
		if (PlayerPrefs.GetString ("block-breaker-paused") == "true") {
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		}
		else {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		
		// Only execute when the powers collide with the paddle
		if(other.gameObject.name == "Paddle") {
			if(this.name == "2x Power Down(Clone)") {
				paddle.speed *= 2f;
				Time.timeScale *= 2f;
			}
			else if(this.name == "0.5x Power Up(Clone)") {
				paddle.speed *= 0.5f;
				Time.timeScale *= 0.5f;
			}
		}
	}

	void RandColor() {
		Color newColor = new Color (Random.value, Random.value, Random.value, 1.0f);
		this.GetComponent<SpriteRenderer> ().color = newColor;
	}
}
