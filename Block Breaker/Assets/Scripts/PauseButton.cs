using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {

	public Text text;
	public string value;

	void Awake() {
		if(value != "Paused")
			gameObject.GetComponent<Button> ().interactable = false;
		text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetString("block-breaker-paused") == "true") {

			// If it's a button
			if(value != "Paused")
				gameObject.GetComponent<Button> ().interactable = true;
			text.text = value;
		}
		else {
			if(value != "Paused")
				gameObject.GetComponent<Button> ().interactable = false;
			text.text = "";
		}
	}
}
