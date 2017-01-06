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
	public bool sameName;
	private GameObject[] activatedPowers;

	// Empty objects to mark which power up is in action
	public GameObject powerDown2x, powerUp0_5x, powerUpExpand, powerDownShrink;

	// Use this for initialization
	void Start () {
		//paddle = GameObject.FindObjectOfType<Paddle> ();
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
		if (other.gameObject.name == "Paddle") {

			// If it's a certain power up, then create the corresponding empty game object
			if(gameObject.name.Contains("2x Power Down"))
				Instantiate (powerDown2x, this.transform.position, this.transform.rotation);
			else if(gameObject.name.Contains("0.5x Power Up"))
				Instantiate (powerUp0_5x, this.transform.position, this.transform.rotation);
			else if(gameObject.name.Contains("Expand Paddle Power Up"))
				Instantiate (powerUpExpand, this.transform.position, this.transform.rotation);
			else if(gameObject.name.Contains("Shrink Paddle Power Down"))
				Instantiate (powerDownShrink, this.transform.position, this.transform.rotation);
			
			Destroy (gameObject);
		}
	}

	void RandColor() {
		Color newColor = new Color (Random.value, Random.value, Random.value, 1.0f);
		this.GetComponent<SpriteRenderer> ().color = newColor;
	}
}