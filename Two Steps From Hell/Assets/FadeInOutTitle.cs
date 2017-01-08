using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOutTitle : MonoBehaviour {

	public Text text;
	private float colorAlpha, animationLength, animationFadeOut;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString ("tsfh fade out", "false");
		text.text = "Two Steps From Hell";
		colorAlpha = 0f;
		animationLength = 1.5f;
		animationFadeOut = 1.5f;
		text.color = new Color (255, 255, 255, colorAlpha);
	}
	
	// Update is called once per frame
	void Update () {
		animationLength -= Time.deltaTime;

		// Fade out animation
		if(PlayerPrefs.GetString("tsfh fade out") == "true") {
			animationFadeOut -= Time.deltaTime;

			if(animationFadeOut >= 0) {
				colorAlpha -= 0.03f;
				text.color = new Color (255, 255, 255, colorAlpha);
			}
		}

		// Fade in duration: 1.5 sec
		else if(animationLength >= 0) {
			colorAlpha += 0.02f;
			text.color = new Color (255, 255, 255, colorAlpha);
		}

		// Destroy when faded out
		if (colorAlpha <= 0.05f && PlayerPrefs.GetString("tsfh fade out") == "true")
			Destroy (gameObject);
	}
}