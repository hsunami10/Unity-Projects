using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagerR : MonoBehaviour {

	public Text text;
	public static bool clicked;

	void Awake() {
		clicked = false;
	}

	void ChangeControls() {
		clicked = true;
	}

	// Update is called once per frame
	void Update () {
		if(clicked) {
			
		}
	}
}
