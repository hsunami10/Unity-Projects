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
	private float alphaValue, timerIn, timerOut;

	void Awake() {
		PlayerPrefs.SetString ("splash button clicked", "false");
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
		timerIn -= Time.deltaTime;

		if(timerIn > 0) {
			alphaValue += 0.02f;
			text.color = new Color (255, 255, 255, alphaValue);
		} else if (PlayerPrefs.GetString("splash button clicked") == "true") {
			timerOut -= Time.deltaTime;

			if(timerOut > 0) {
				alphaValue -= 0.02f;
				text.color = new Color (255, 255, 255, alphaValue);
			}
		}

		if (timerOut < 0)
			SceneManager.LoadScene ("Main_Menu");
	}
}
