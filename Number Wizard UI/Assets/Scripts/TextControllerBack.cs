using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControllerBack : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Alpha2))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Alpha3))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Alpha4))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Alpha5))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Alpha6))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Keypad1))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Keypad2))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Keypad3))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Keypad4))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Keypad5))
			text.text = "Back";
		else if (Input.GetKeyDown (KeyCode.Keypad6))
			text.text = "Back";
	}
}
