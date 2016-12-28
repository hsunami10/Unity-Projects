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

	// Use this for initialization
	void Start () {
		
		// If you beat Forest Lvl 1, then enable the Forest Lvl 1+1 button
		if (PlayerPrefs.GetInt ("block-breaker-beat-forest-level") == 1 && LevelNumber == 2) {
			button.interactable = true;
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 2 && LevelNumber == 3) {
			button.interactable = true;
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 3 && LevelNumber == 4) {
			button.interactable = true;
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 4 && LevelNumber == 5) {
			button.interactable = true;
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 5 && LevelNumber == 6) {
			button.interactable = true;
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 6 && LevelNumber == 7) {
			button.interactable = true;
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 7 && LevelNumber == 8) {
			button.interactable = true;
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 8 && LevelNumber == 9) {
			button.interactable = true;
		} else if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 9 && LevelNumber == 10) {
			button.interactable = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
