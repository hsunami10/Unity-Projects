using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchMessage : MonoBehaviour {

	public Text text;

	void Awake() {
		text.text = "PRESS SPACE TO LAUNCH THE BALL";
		Time.timeScale = 0f;
	}
	void Start() {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Destroy (gameObject);
			Time.timeScale = 1f;
		}
		if(Input.GetKeyDown(KeyCode.Escape))
			text.text = "";
	}
}
