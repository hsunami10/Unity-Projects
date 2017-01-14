using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Fades the splash screen text in and out
/// </summary>
public class FadeTextIn : MonoBehaviour {

	public Text text;
	private Button button;
	private float alphaValue, timerIn, timerOut;
	private bool fadedOut;

	void Awake() {
		PlayerPrefs.SetString ("splash button clicked", "false");
		PlayerPrefs.SetString ("scene fade", "true");
		PlayerPrefs.SetString ("faded out", "false");
		button = GameObject.FindObjectOfType<Button> ();
		button.interactable = false;
		fadedOut = false;
	}

	// Use this for initialization
	void Start () {
		alphaValue = 0;
		timerIn = 2f;
		timerOut = 2f;
		text.text = "Please hold your device as flat as you can for optimal performance.";
		text.color = new Color (255, 255, 255, alphaValue);
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetString("splash button clicked") == "true") {
			timerOut -= Time.deltaTime;

			if(timerOut > 0) {
				alphaValue -= 0.03f;
				text.color = new Color (255, 255, 255, alphaValue);
			}
		} else if(timerIn > 0) {
			timerIn -= Time.deltaTime;

			alphaValue += 0.02f;
			text.color = new Color (255, 255, 255, alphaValue);
		}
		if (timerIn < 0) {
			button.interactable = true;
			fadedOut = true;
		}
		if (alphaValue <= 0.05f && fadedOut == true)
			SceneManager.LoadScene ("Main_Menu");
	}
}
