using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This sets the min and max values (the range)
/// </summary>
public class NumberWizard : MonoBehaviour {

	public static int min, max, guess;
	private bool rangeChosen = false;

	void Update() {
		if (!rangeChosen) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				min = 1;
				max = 100;
				rangeChosen = true;

				// Stores integers in computer, saved even if game is closed
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 8);
			} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
				min = 1;
				max = 500;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 10);
			} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
				min = 1;
				max = 1000;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 12);
			} else if (Input.GetKeyDown (KeyCode.Alpha4)) {
				min = 1;
				max = 10000;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 20);
			} else if (Input.GetKeyDown (KeyCode.Alpha5)) {
				min = 1;
				max = 100000;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 35);
			} else if (Input.GetKeyDown (KeyCode.Alpha6)) {
				min = 1;
				max = 1000000;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 60);
			} else if (Input.GetKeyDown (KeyCode.Keypad1)) {
				min = 1;
				max = 100;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 8);
			} else if (Input.GetKeyDown (KeyCode.Keypad2)) {
				min = 1;
				max = 500;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 10);
			} else if (Input.GetKeyDown (KeyCode.Keypad3)) {
				min = 1;
				max = 1000;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 12);
			} else if (Input.GetKeyDown (KeyCode.Keypad4)) {
				min = 1;
				max = 10000;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 20);
			} else if (Input.GetKeyDown (KeyCode.Keypad5)) {
				min = 1;
				max = 100000;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 35);
			} else if (Input.GetKeyDown (KeyCode.Keypad6)) {
				min = 1;
				max = 1000000;
				rangeChosen = true;
				PlayerPrefs.SetInt ("min", min);
				PlayerPrefs.SetInt ("max", max);
				PlayerPrefs.SetInt ("maxGuesses", 60);
			}
		}
	}
}
