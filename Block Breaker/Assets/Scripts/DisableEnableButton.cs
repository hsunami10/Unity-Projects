using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Enables and disables the level buttons
/// </summary>
public class DisableEnableButton : MonoBehaviour {

	public Button button;

	// Each button has a different level number
	public int LevelNumber;

	// List of enabled buttons
	private static List<int> enableButtonsForest = new List<int>();
	private static int[] enableButtonsForestArray;

	private static List<int> enableButtonsSnow = new List<int> ();
	private static int[] enableButtonsSnowArray;

	// Use this for initialization
	void Start () {

		// Do this for each environment

		// Forest
		for(int i = 0; i < PlayerPrefs.GetInt("block-breaker-beat-highest-forest-level"); i++) {
			enableButtonsForest.Add (i + 2);
		}
		enableButtonsForestArray = enableButtonsForest.ToArray ();
		for (int i = 0; i < enableButtonsForestArray.Length; i++) {
			if (LevelNumber == enableButtonsForestArray [i])
				button.interactable = true;
		}

		// Snow
		for(int i = 0; i < PlayerPrefs.GetInt("block-breaker-beat-highest-snow-level"); i++) {
			enableButtonsSnow.Add (i + 12);
		}
		enableButtonsSnowArray = enableButtonsSnow.ToArray ();
		for (int i = 0; i < enableButtonsSnowArray.Length; i++) {
			if (LevelNumber == enableButtonsSnowArray [i])
				button.interactable = true;
		}
	}
}
