using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Loads and quits scenes
/// </summary>
public class LevelManager : MonoBehaviour {

	// Load scenes
	public void LoadLevel(string name) {
		//PlayerPrefs.DeleteKey ("block-breaker-beat-forest-level");
		// Set current environment and level for use in Brick.cs
		if (name == "Level_01_Forest") {
			PlayerPrefs.SetInt ("block-breaker-current-level", 1);
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");
		} else if (name == "Level_02_Forest") {
			PlayerPrefs.SetInt ("block-breaker-current-level", 2);
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");
		} else if (name == "Level_03_Forest") {
			PlayerPrefs.SetInt ("block-breaker-current-level", 3);
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");
		} else if (name == "Level_04_Forest") {
			PlayerPrefs.SetInt ("block-breaker-current-level", 4);
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");
		} else if (name == "Level_05_Forest") {
			PlayerPrefs.SetInt ("block-breaker-current-level", 5);
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");
		} else if (name == "Level_06_Forest") {
			PlayerPrefs.SetInt ("block-breaker-current-level", 6);
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");
		} else if (name == "Level_07_Forest") {
			PlayerPrefs.SetInt ("block-breaker-current-level", 7);
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");
		} else if (name == "Level_08_Forest") {
			PlayerPrefs.SetInt ("block-breaker-current-level", 8);
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");
		} else if (name == "Level_09_Forest") {
			PlayerPrefs.SetInt ("block-breaker-current-level", 9);
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");
		} else if (name == "Level_10_Forest") {
			PlayerPrefs.SetInt ("block-breaker-current-level", 10);
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");
		}
		SceneManager.LoadScene (name);
	}

	// Quit application
	public void QuitRequest() {
		Application.Quit ();
	}

	// Link to website
	public void OpenUrl(string url) {
		Application.OpenURL (url);
	}

	void Update() {
		// Handle game paused here
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Time.timeScale = 0f;
		}
	}
}
