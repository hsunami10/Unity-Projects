using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Cast int to enum
// KeyCode left = (KeyCode)leftControl;

public class ButtonManager : MonoBehaviour {

	public Text text;
	public static bool clicked;
	private int leftControl;

	void Awake() {
		clicked = false;
	}

	public void ChangeControls() {
		clicked = true;
	}

	// Update is called once per frame
	void Update () {
		if(clicked) {

			// Allow the player to set their own controls
			// Top row
			if (Input.GetKeyUp (KeyCode.Escape)) {
				text.text = "Esc";
				leftControl = (int)KeyCode.Escape;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F1)) {
				text.text = "F1";
				leftControl = (int)KeyCode.F1;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F2)) {
				text.text = "F2";
				leftControl = (int)KeyCode.F2;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F3)) {
				text.text = "F3";
				leftControl = (int)KeyCode.F3;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F4)) {
				text.text = "F4";
				leftControl = (int)KeyCode.F4;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F5)) {
				text.text = "F5";
				leftControl = (int)KeyCode.F5;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F6)) {
				text.text = "F6";
				leftControl = (int)KeyCode.F6;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F7)) {
				text.text = "F7";
				leftControl = (int)KeyCode.F7;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F8)) {
				text.text = "F8";
				leftControl = (int)KeyCode.F8;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F9)) {
				text.text = "F9";
				leftControl = (int)KeyCode.F9;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F10)) {
				text.text = "F10";
				leftControl = (int)KeyCode.F10;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F11)) {
				text.text = "F11";
				leftControl = (int)KeyCode.F11;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F12)) {
				text.text = "F12";
				leftControl = (int)KeyCode.F12;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Insert)) {
				text.text = "Ins";
				leftControl = (int)KeyCode.Insert;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Delete)) {
				text.text = "Delete";
				leftControl = (int)KeyCode.Delete;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}

			// Second top row
			if (Input.GetKeyUp (KeyCode.BackQuote)) {
				text.text = "`";
				leftControl = (int)KeyCode.BackQuote;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha0)) {
				text.text = "NUM0";
				leftControl = (int)KeyCode.Alpha0;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha1)) {
				text.text = "NUM1";
				leftControl = (int)KeyCode.Alpha1;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha2)) {
				text.text = "NUM2";
				leftControl = (int)KeyCode.Alpha2;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha3)) {
				text.text = "NUM3";
				leftControl = (int)KeyCode.Alpha3;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha4)) {
				text.text = "NUM4";
				leftControl = (int)KeyCode.Alpha4;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha5)) {
				text.text = "NUM5";
				leftControl = (int)KeyCode.Alpha5;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha6)) {
				text.text = "NUM6";
				leftControl = (int)KeyCode.Alpha6;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha7)) {
				text.text = "NUM7";
				leftControl = (int)KeyCode.Alpha7;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha8)) {
				text.text = "NUM8";
				leftControl = (int)KeyCode.Alpha8;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha9)) {
				text.text = "NUM9";
				leftControl = (int)KeyCode.Alpha9;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Minus)) {
				text.text = "-";
				leftControl = (int)KeyCode.Minus;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Equals)) {
				text.text = "=";
				leftControl = (int)KeyCode.Equals;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Backspace)) {
				text.text = "Backspace";
				leftControl = (int)KeyCode.Backspace;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}

			// Third top row

		}
	}
}
