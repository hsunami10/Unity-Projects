using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Background : MonoBehaviour {

	private float duration;
	private Color normColor;

	// Use this for initialization
	void Start () {
		duration = 1.5f;
		normColor = gameObject.GetComponent<SpriteRenderer> ().color;
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetString ("tsfh fade out") == "true") {
			duration -= Time.deltaTime;

			if (duration <= 0)
				SceneManager.LoadScene ("Playlist_Menu");
		}
	}
}
