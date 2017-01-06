using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Spawned every time the power is activated, delete after 10 sec
/// </summary>
public class PowerTimer : MonoBehaviour {

	private float powerLast;
	private bool once;
	private Paddle paddle;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		// Each power lasts for 10 sec
		powerLast = 10 * Brick.totalBricks * Time.timeScale;
		once = false;

		// *** Change for each power up ***
		// Check type of power up, and change properties
		if (gameObject.name.Contains ("2x Power Down")) {
			Paddle.speed *= 2f;
			Time.timeScale *= 2f;
		} else if (gameObject.name.Contains ("0.5x Power Up")) {
			Paddle.speed *= 0.5f;
			Time.timeScale *= 0.5f;
		} else if (gameObject.name.Contains ("Expand Paddle Power Up")) {
			paddle.transform.localScale += new Vector3 (0.5f, 0f, 0f);
		} else if(gameObject.name.Contains("Shrink Paddle Power Down")) {
			paddle.transform.localScale -= new Vector3 (0.5f, 0f, 0f);
		}
	}

	// Update is called once per frame
	void Update () {

		// If time is changed, then change the 10sec according to the time scale ONCE
		if (!once) {
			if (Time.timeScale != 1f)
				powerLast = 10 * Time.timeScale;
			else
				powerLast = 10;
			once = true;
		}
		
		powerLast -= Time.deltaTime;

		// Disable powers after 10 seconds
		if (powerLast <= 0) {

			// Reset values and disable
			// *** Change for each power up ***
			if (gameObject.name.Contains ("2x Power Down")) {
				Time.timeScale *= 0.5f;
				Paddle.speed *= 0.5f;
			} else if (gameObject.name.Contains ("0.5x Power Up")) {
				Time.timeScale *= 2f;
				Paddle.speed *= 2f;
			} else if (gameObject.name.Contains ("Expand Paddle Power Up")) {
				paddle.transform.localScale -= new Vector3 (0.5f, 0f, 0f);
			} else if (gameObject.name.Contains("Shrink Paddle Power Down")) {
				paddle.transform.localScale += new Vector3 (0.5f, 0f, 0f);
			}
			

			Destroy (gameObject);
		}
	}
}
