using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOutCredits : MonoBehaviour {

	public Text text;
	private float animationDelay, colorAlpha, animationLength, animationFadeOut;
	private float stay;

	// Use this for initialization
	void Start () {
		text.text = "Music created by: Thomas Bergerson and Nick Phoenix.";
		colorAlpha = 0f;
		animationLength = 1.5f;
		animationDelay = 1.5f;
		animationFadeOut = 1.5f;
		stay = 1f;
		text.color = new Color (255, 255, 255, colorAlpha);
	}
	
	// Update is called once per frame
	void Update () {
		animationDelay -= Time.deltaTime;

		// Fade out
		if(PlayerPrefs.GetString("tsfh fade out") == "true") {
			animationFadeOut -= Time.deltaTime;

			if(animationFadeOut >= 0) {
				colorAlpha -= 0.03f;
				text.color = new Color (255, 255, 255, colorAlpha);
			}
		}

		// Start fade in after title fades in
		else if(animationDelay <= 0) {
			animationLength -= Time.deltaTime;

			// Fade in duration: 1.5 sec
			if(animationLength >= 0) {
				colorAlpha += /*0.0121f;*/0.02f;
				text.color = new Color (255, 255, 255, colorAlpha);
			}

			// Stay on screen for 2 sec
			if(animationLength <= 0) {
				stay -= Time.deltaTime;

				if (stay <= 0)
					PlayerPrefs.SetString ("tsfh fade out", "true");
			}
		}

		// Destroy when faded out
		if (colorAlpha <= 0.05f && PlayerPrefs.GetString("tsfh fade out") == "true")
			Destroy (gameObject);
	}
}
