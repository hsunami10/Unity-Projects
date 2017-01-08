using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour {

	private float duration, colorAlpha;
	private Color normColor;

	// Use this for initialization
	void Start () {
		duration = 1.5f;
		colorAlpha = 1f;
		normColor = gameObject.GetComponent<SpriteRenderer> ().color;
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetString ("tsfh fade out") == "true") {
			duration -= Time.deltaTime;

			// Dim background once title and caption fade out
			if (duration >= 0) {
				colorAlpha -= 0.009f;
				normColor.a = colorAlpha;
				gameObject.GetComponent<SpriteRenderer> ().color = normColor;
			}
		}
	}
}
