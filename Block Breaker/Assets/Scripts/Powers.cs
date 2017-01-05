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
	public GameObject powerDown2x, powerUp0_5x;

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

			// If there's already a power in use...
/*			if (GameObject.FindGameObjectsWithTag ("Power Activated").Length == 1) {
				print ("a power up already exists");

				// If not the same type of power, then change the power
				if(GameObject.FindGameObjectsWithTag ("Power Activated")[0].name.Replace(" Activated(Clone)", "") != this.name.Replace("(Clone)", "")) {
					if (this.name == "2x Power Down(Clone)") {
						Paddle.speed = 0.16f;
						Paddle.speed *= 2f;
						Time.timeScale = 2f;
						GameObject.FindGameObjectsWithTag ("Power Activated")[0] = Instantiate (powerDown2x, this.transform.position, this.transform.rotation) as GameObject;
					} else if (this.name == "0.5x Power Up(Clone)") {
						Paddle.speed = 0.16f;
						Paddle.speed *= 0.5f;
						Time.timeScale = 0.5f;
						GameObject.FindGameObjectsWithTag ("Power Activated")[0] = Instantiate (powerDown2x, this.transform.position, this.transform.rotation) as GameObject;
					}

				} else {
					// If same name, recharge power

				}
			} */

			// If there's already a power in use...
			if(PlayerPrefs.GetString("block-breaker-power-active") == "true") {
				print ("a power up already exists");

				// If not the same type of power, then add the power
				if(GameObject.FindGameObjectsWithTag ("Power Activated")[0].name.Replace(" Activated(Clone)", "") != this.name.Replace("(Clone)", "")) {
					if (this.name == "2x Power Down(Clone)") {
						Paddle.speed *= 2f;
						Time.timeScale *= 2f;
						GameObject.FindGameObjectsWithTag ("Power Activated")[0] = Instantiate (powerDown2x, this.transform.position, this.transform.rotation) as GameObject;
					} else if (this.name == "0.5x Power Up(Clone)") {
						Paddle.speed = 0.16f;
						Paddle.speed *= 0.5f;
						Time.timeScale = 0.5f;
						GameObject.FindGameObjectsWithTag ("Power Activated")[0] = Instantiate (powerDown2x, this.transform.position, this.transform.rotation) as GameObject;
					}

				} else {
					// If same name, recharge power

				}
			} else {
				// If a power is not in use, create empty objects when a power is activated
				if (this.name == "2x Power Down(Clone)") {
					Paddle.speed *= 2f;
					Time.timeScale *= 2f;
					Instantiate (powerDown2x, this.transform.position, this.transform.rotation);
					PlayerPrefs.SetString ("block-breaker-power-active", "true");
				} else if (this.name == "0.5x Power Up(Clone)") {
					Paddle.speed *= 0.5f;
					Time.timeScale *= 0.5f;
					Instantiate (powerUp0_5x, this.transform.position, this.transform.rotation);
					PlayerPrefs.SetString ("block-breaker-power-active", "true");
				}
			}
		}
	}

	void RandColor() {
		Color newColor = new Color (Random.value, Random.value, Random.value, 1.0f);
		this.GetComponent<SpriteRenderer> ().color = newColor;
	}
}