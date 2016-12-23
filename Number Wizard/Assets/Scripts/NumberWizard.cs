using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	#region Global Variables
	private int min, max, guess;
	private int term = 0;
	private bool gameEnded = false;
	#endregion

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame() {
		print ("==========================");
		print ("Welcome to Number Wizard!");
		print ("Created by: Michael Hsu");
		print ("Choose a number range: 1-100 (1), 1-500 (2), 1-1000 (3), 1-10000 (4), 1-100000 (5), 1-1000000 (6)");
		print ("Pick a number in your head, but don't tell me!");
	}
	
	// Update is called once per frame
	void Update () {
		if (term == 0) {
			if (Input.GetKeyDown (KeyCode.Alpha1)) {
				max = 100;
				min = 1;
				InitialGuess ();
			} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
				max = 500;
				min = 1;
				InitialGuess ();
			} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
				max = 1000;
				min = 1;
				InitialGuess ();
			} else if (Input.GetKeyDown (KeyCode.Alpha4)) {
				max = 10000;
				min = 1;
				InitialGuess ();
			} else if (Input.GetKeyDown (KeyCode.Alpha5)) {
				max = 100000;
				min = 1;
				InitialGuess ();
			} else if (Input.GetKeyDown (KeyCode.Alpha6)) {
				max = 1000000;
				min = 1;
				InitialGuess ();
			}
		} else {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				min = guess;
				NextGuess ();
			} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
				max = guess;
				NextGuess ();
			} else if (Input.GetKeyDown (KeyCode.Return)) {
				print ("I won!");
				print ("Play again? Yes (y) or No (n)");
				gameEnded = true;
			}
		}
		if(gameEnded) {
			if (Input.GetKeyDown (KeyCode.Y)) {
				term = 0;
				StartGame ();
			} else if (Input.GetKeyDown (KeyCode.N))
				print ("You have ended the game.");
				Application.Quit ();
		}
	}

	void InitialGuess() {
		guess = (int)(Random.value * (max - 1) + 1);
		term++;
		print ("You chose: " + min + "-" + max);
		print ("Is the number higher or lower than " + guess + "?");
		print ("up = higher, down = lower, return = equal");
		max += 1;
	}

	void NextGuess() {
		guess = (max + min) / 2;
		print ("Is the number higher or lower than " + guess + "?");
		print ("up = higher, down = lower, return = equal");
	}
}
