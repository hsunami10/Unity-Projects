using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizardGame : MonoBehaviour {

	private int min, max, guess, maxGuesses;
	public Text text;

	// Use this for initialization
	void Start () {

		// Gets integers stored in computer
		min = PlayerPrefs.GetInt ("min");
		max = PlayerPrefs.GetInt ("max");
		maxGuesses = PlayerPrefs.GetInt ("maxGuesses");
		NextGuess ();
	}
	
	public void GuessHigher() {
		min = guess;
		NextGuess ();
	}

	public void GuessLower() {
		max = guess;
		NextGuess ();
	}

	void NextGuess() {
		guess = Random.Range (min, max+1);
		text.text = "Is this your number? " + guess;
		maxGuesses -= 1;
		if(maxGuesses <= 0) {
			// When the computer hits max guesses, move to win scene
			Application.LoadLevel ("Win");
		}
	}
}
