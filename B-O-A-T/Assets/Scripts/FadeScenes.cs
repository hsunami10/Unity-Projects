using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScenes : MonoBehaviour {

	private float alphaValue, fadeInTimer, fadeOutTimer;

	void Awake() {

		// Locally set black image parent to canvas
		transform.SetParent (GameObject.FindObjectOfType<Canvas> ().transform, false);
	}

	// Use this for initialization
	void Start () {
		fadeInTimer = 1f;
		fadeOutTimer = 1f;

		if (PlayerPrefs.GetString ("scene fade") == "false" && PlayerPrefs.GetString ("faded out") == "true")
			alphaValue = 1f;
		else if (PlayerPrefs.GetString ("scene fade") == "true" && PlayerPrefs.GetString ("faded out") == "false")
			alphaValue = 0f;
		
		gameObject.GetComponent<Image> ().color = new Color (0, 0, 0, alphaValue);
	}
	
	// Update is called once per frame
	void Update () {
		
		// If you want to fade out a scene, then fade in the black image
		if (PlayerPrefs.GetString ("scene fade") == "true" && PlayerPrefs.GetString ("faded out") == "false") {
			fadeInTimer -= Time.deltaTime;

			if (fadeInTimer > 0) {
				alphaValue += 0.04f;
				gameObject.GetComponent<Image> ().color = new Color (0, 0, 0, alphaValue);
			} else {
				PlayerPrefs.SetString ("faded out", "true");
				PlayerPrefs.SetString ("scene fade", "false");
				SceneManager.LoadScene (PlayerPrefs.GetString("LoadLevel"));
			}
			
		} else if (PlayerPrefs.GetString ("scene fade") == "false" && PlayerPrefs.GetString ("faded out") == "true") {
			fadeOutTimer -= Time.deltaTime;

			if(fadeOutTimer > 0) {
				alphaValue -= 0.04f;
				gameObject.GetComponent<Image> ().color = new Color (0, 0, 0, alphaValue);
			} else {
				PlayerPrefs.SetString ("faded out", "false");
				PlayerPrefs.SetString ("scene fade", "true");
				SceneManager.LoadScene (PlayerPrefs.GetString("LoadLevel"));
			}
		}
	}
}