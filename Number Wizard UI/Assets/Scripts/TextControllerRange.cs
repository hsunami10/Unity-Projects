using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControllerRange : MonoBehaviour {

	public Text text;
	private bool choose;

	// Use this for initialization
	void Start () {
		text.text = "Choose a number range (1-6):\n(1) 1-100\n(2) 1-500\n(3) 1-1000\n(4) 1-10000\n(5) 1-100000\n(6) 1-1000000";
		//text.text = "Think of a number between 1-1000!";/*Hardcode version*/
		choose = false;
	}

	// Update is called once per frame
	void Update () {
		if (!choose) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				text.text = "You have chosen 1-100.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
				text.text = "You have chosen 1-500.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
				text.text = "You have chosen 1-1000.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Alpha4)) {
				text.text = "You have chosen 1-10000.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Alpha5)) {
				text.text = "You have chosen 1-100000.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Alpha6)) {
				text.text = "You have chosen 1-1000000.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Keypad1)) {
				text.text = "You have chosen 1-100.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Keypad2)) {
				text.text = "You have chosen 1-500.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Keypad3)) {
				text.text = "You have chosen 1-1000.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Keypad4)) {
				text.text = "You have chosen 1-10000.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Keypad5)) {
				text.text = "You have chosen 1-100000.\nThink of a number in this range!";
				choose = true;
			} else if (Input.GetKeyDown (KeyCode.Keypad6)) {
				text.text = "You have chosen 1-1000000.\nThink of a number in this range!";
				choose = true;
			}
		}
	}
}
