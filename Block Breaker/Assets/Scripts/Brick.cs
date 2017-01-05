using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brick : MonoBehaviour {
	
	public int maxHits;
	private int timesHit;
	private static int bricksDestroyed;
	public GameObject[] powers;
	private int random;
	public static float powerLast;
	private bool once;

	// Total number of bricks in each lvl - doesn't count invincible bricks
	private int totalBricks;

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetInt ("random", (int)Random.Range (4, 7.99f));
		PlayerPrefs.SetString ("block-breaker-power-active", "false");

		// Reset values
		timesHit = 0;
		bricksDestroyed = 0;
		Time.timeScale = 1f;
		once = false;

		// Check the current environment and level, and set the total bricks in that level

		// Forest
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 1 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			totalBricks = 17;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 2 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			totalBricks = 14;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 3 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			totalBricks = 23;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 4 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			totalBricks = 34;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 5 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			totalBricks = 36;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 6 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			totalBricks = 37;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 7 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			totalBricks = 43;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 8 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			totalBricks = 54;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 9 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			totalBricks = 39;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 10 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			totalBricks = 61;

		// Snow
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 11 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			totalBricks = 32;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 12 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			totalBricks = 28;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 13 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			totalBricks = 40;
	/*	else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 14 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			totalBricks = 34;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 15 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			totalBricks = 36;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 16 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			totalBricks = 38;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 17 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			totalBricks = 44;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 18 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			totalBricks = 54;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 19 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			totalBricks = 39;
		else if (PlayerPrefs.GetInt ("block-breaker-current-level") == 20 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			totalBricks = 61;*/

		// Each power lasts for 10 sec
		powerLast = 10 * totalBricks * Time.timeScale;
	}

	void OnCollisionEnter2D(Collision2D collision) {
		
		// Check whether the block is breakable
		bool isBreakable = (this.tag == "Breakable");

		if (isBreakable)
			HandleHits ();
	}

	void HandleHits() {
		timesHit++;

		// Change colors according to how many hits are left
		if(maxHits - timesHit == 1) {
			Color newColor = new Color (230, 255, 0, 255);
			gameObject.GetComponent<SpriteRenderer> ().color = newColor;
		}
		else if(maxHits - timesHit == 2) {
			Color newColor = new Color (0, 234, 255, 255);
			gameObject.GetComponent<SpriteRenderer> ().color = newColor;
		}
		else if(maxHits - timesHit == 3) {
			Color newColor = new Color (0, 255, 33, 255);
			gameObject.GetComponent<SpriteRenderer> ().color = newColor;
		}
		else if(maxHits - timesHit == 4) {
			Color newColor = new Color (230, 0, 255, 255);
			gameObject.GetComponent<SpriteRenderer> ().color = newColor;
		}
	}
	
	// Update is called once per frame
	void Update () {
		powerLast -= Time.deltaTime;

		print (powerLast + " " + Time.timeScale);

		// If a power is activated, then delete it after 10sec
		if(PlayerPrefs.GetString("block-breaker-power-active") == "true") {
			
			// If time is changed, then change the 10sec according to the time scale ONCE
			if (Time.timeScale != 1f && !once) {
				powerLast = 10 * totalBricks * Time.timeScale;
				once = true;
			}

			// powerLast decreases too slowly??? Fix this!!!!
			powerLast -= Time.deltaTime;
			print (powerLast + " " + Time.timeScale);

			// Disable powers after 10 seconds
			if(powerLast <= 0) {

				if (Time.timeScale != 1f) {
					Time.timeScale = 1f;
					Paddle.speed = 0.16f;
				}

				// Reset values
				powerLast = 10 * totalBricks * Time.timeScale;

				// Disable
				PlayerPrefs.SetString("block-breaker-power-active", "false");
			}
		}

		// If the times a block is hit equates the max number of hits, then it's destroyed
		if (timesHit >= maxHits) {
			bricksDestroyed++;
			Destroy (gameObject);

			// Spawn a power every 4-7 blocks destroyed - only reset random when this code runs
			if (bricksDestroyed % PlayerPrefs.GetInt("random") == 0) {
				Instantiate (powers [(int)Random.Range (1, 1.99f)], this.transform.position, this.transform.rotation);
				
				PlayerPrefs.SetInt ("random", (int)Random.Range (4, 7.99f));
			}
		}

		// If all bricks are destroyed, load congratulations scene
		if (bricksDestroyed == totalBricks)
			SceneManager.LoadScene ("Beat_Level");

		// Paused menu
		if (PlayerPrefs.GetString ("block-breaker-paused") == "true") {
			gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		}
		else {
			gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}
