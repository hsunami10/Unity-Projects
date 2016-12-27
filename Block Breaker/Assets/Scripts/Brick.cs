using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;
	private static int bricksDestroyed;

	// Total number of bricks in each lvl
	private int forestBricksLvl1, forestBricksLvl2;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		bricksDestroyed = 0;
		forestBricksLvl1 = 25;
	}

	void OnCollisionEnter2D(Collision2D collision) {
		timesHit++;

		// Change colors according to how many hits are left
		if(maxHits == 2 && timesHit == 1 || maxHits == 3 && timesHit == 2 || maxHits == 4 && timesHit == 3 || maxHits == 5 && timesHit == 4) {
			Color newColor = new Color (230, 255, 0, 255);
			gameObject.GetComponent<SpriteRenderer> ().color = newColor;
		}
		else if(maxHits == 3 && timesHit == 1 || maxHits == 4 && timesHit == 2 || maxHits == 5 && timesHit == 3) {
			Color newColor = new Color (0, 234, 255, 255);
			gameObject.GetComponent<SpriteRenderer> ().color = newColor;
		}
		else if(maxHits == 4 && timesHit == 1 || maxHits == 5 && timesHit == 2) {
			Color newColor = new Color (230, 0, 255, 255);
			gameObject.GetComponent<SpriteRenderer> ().color = newColor;
		}
		else if(maxHits == 5 && timesHit == 1) {
			Color newColor = new Color (0, 255, 33, 255);
			gameObject.GetComponent<SpriteRenderer> ().color = newColor;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (timesHit == maxHits) {
			bricksDestroyed += 1;
			Destroy (gameObject);
		}

		// Beat Level 1 once all bricks are destroyed, load congratulations scene
		if(bricksDestroyed == forestBricksLvl1) {
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 1);
			SceneManager.LoadScene ("Beat_Level");
		}
	}
}
