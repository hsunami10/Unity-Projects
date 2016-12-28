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

	void Awake() {
		if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 1 && LevelNumber == 2) {
			enableButtonsForest.Add (LevelNumber);
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 2 && LevelNumber == 3) {
			enableButtonsForest.Add (LevelNumber);
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 3 && LevelNumber == 4) {
			enableButtonsForest.Add (LevelNumber);
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 4 && LevelNumber == 5) {
			enableButtonsForest.Add (LevelNumber);
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 5 && LevelNumber == 6) {
			enableButtonsForest.Add (LevelNumber);
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 6 && LevelNumber == 7) {
			enableButtonsForest.Add (LevelNumber);
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 7 && LevelNumber == 8) {
			enableButtonsForest.Add (LevelNumber);
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 8 && LevelNumber == 9) {
			enableButtonsForest.Add (LevelNumber);
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 9 && LevelNumber == 10) {
			enableButtonsForest.Add (LevelNumber);
		}
	}

	// Use this for initialization
	void Start () {
		enableButtonsForestArray = enableButtonsForest.ToArray ();

		// Account for the one size List on game start -> ex. if LevelNumber = 4, diff = 2, add 2 and 3
		int diff = enableButtonsForestArray[0] - 2;
		for(int i = 0; i < diff; i++) {
			enableButtonsForest.Add (i+2);
		}
		enableButtonsForestArray = enableButtonsForest.ToArray ();

		for(int i = 0; i < enableButtonsForestArray.Length; i++) {
			if (LevelNumber == enableButtonsForestArray [i])
				button.interactable = true;
		}
	}
}
