using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchMessage : MonoBehaviour {

	public Text text;

	void Awake() {
		text.text = "PRESS SPACE TO LAUNCH THE BALL";
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			Destroy (gameObject);
		if(Input.GetKeyDown(KeyCode.Escape))
			text.text = "";
	}
}
