using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Loads and quits scenes - includes Pause Menu
/// </summary>
public class LevelManager : MonoBehaviour {

	// Load scenes
	public void LoadLevel(string name) {
		
		// Set current environment and level for use in Brick.cs

		// Forest - "unpause" every time the level starts
		if(name.Contains("Forest") && name.Contains("Level")) {
			PlayerPrefs.SetString ("block-breaker-paused", "false");
			PlayerPrefs.SetString ("block-breaker-current-environment", "forest");

			if (name.Substring (6, 2) == "01")
				PlayerPrefs.SetInt ("block-breaker-current-level", 1);
			else if (name.Substring (6, 2) == "02")
				PlayerPrefs.SetInt ("block-breaker-current-level", 2);
			else if (name.Substring (6, 2) == "03")
				PlayerPrefs.SetInt ("block-breaker-current-level", 3);
			else if (name.Substring (6, 2) == "04")
				PlayerPrefs.SetInt ("block-breaker-current-level", 4);
			else if (name.Substring (6, 2) == "05")
				PlayerPrefs.SetInt ("block-breaker-current-level", 5);
			else if (name.Substring (6, 2) == "06")
				PlayerPrefs.SetInt ("block-breaker-current-level", 6);
			else if (name.Substring (6, 2) == "07")
				PlayerPrefs.SetInt ("block-breaker-current-level", 7);
			else if (name.Substring (6, 2) == "08")
				PlayerPrefs.SetInt ("block-breaker-current-level", 8);
			else if (name.Substring (6, 2) == "09")
				PlayerPrefs.SetInt ("block-breaker-current-level", 9);
			else if (name.Substring (6, 2) == "10")
				PlayerPrefs.SetInt ("block-breaker-current-level", 10);
		}

		// Snow
		else if(name.Contains("Snow") && name.Contains("Level")) {
			PlayerPrefs.SetString ("block-breaker-paused", "false");
			PlayerPrefs.SetString ("block-breaker-current-environment", "snow");

			if (name.Substring (6, 2) == "01")
				PlayerPrefs.SetInt ("block-breaker-current-level", 11);
			else if (name.Substring (6, 2) == "02")
				PlayerPrefs.SetInt ("block-breaker-current-level", 12);
			else if (name.Substring (6, 2) == "03")
				PlayerPrefs.SetInt ("block-breaker-current-level", 13);
			else if (name.Substring (6, 2) == "04")
				PlayerPrefs.SetInt ("block-breaker-current-level", 14);
			else if (name.Substring (6, 2) == "05")
				PlayerPrefs.SetInt ("block-breaker-current-level", 15);
			else if (name.Substring (6, 2) == "06")
				PlayerPrefs.SetInt ("block-breaker-current-level", 16);
			else if (name.Substring (6, 2) == "07")
				PlayerPrefs.SetInt ("block-breaker-current-level", 17);
			else if (name.Substring (6, 2) == "08")
				PlayerPrefs.SetInt ("block-breaker-current-level", 18);
			else if (name.Substring (6, 2) == "09")
				PlayerPrefs.SetInt ("block-breaker-current-level", 19);
			else if (name.Substring (6, 2) == "10")
				PlayerPrefs.SetInt ("block-breaker-current-level", 20);
		}

		SceneManager.LoadScene (name);

		if(name == "Start")
			Time.timeScale = 1f;
	}

	// Quit application
	public void QuitRequest() {
		Application.Quit ();
	}

	// Link to website
	public void OpenUrl(string url) {
		Application.OpenURL (url);
	}

	// Continue game
	public void Continue() {
		PlayerPrefs.SetString ("block-breaker-paused", "false");
		Time.timeScale = 1f;
	}

	// Restart level
	public void Restart() {
		PlayerPrefs.SetString ("block-breaker-paused", "false");
		Time.timeScale = 1f;
		SceneManager.LoadScene (Application.loadedLevel);
	}

	// Retry level when game over
	public void Retry() {

		// Forest
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 1 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			SceneManager.LoadScene ("Level_01_Forest");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 2 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			SceneManager.LoadScene ("Level_02_Forest");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 3 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			SceneManager.LoadScene ("Level_03_Forest");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 4 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			SceneManager.LoadScene ("Level_04_Forest");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 5 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			SceneManager.LoadScene ("Level_05_Forest");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 6 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			SceneManager.LoadScene ("Level_06_Forest");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 7 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			SceneManager.LoadScene ("Level_07_Forest");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 8 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			SceneManager.LoadScene ("Level_08_Forest");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 9 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			SceneManager.LoadScene ("Level_09_Forest");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 10 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest")
			SceneManager.LoadScene ("Level_10_Forest");

		// Snow
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 11 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			SceneManager.LoadScene ("Level_01_Snow");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 12 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			SceneManager.LoadScene ("Level_02_Snow");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 13 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			SceneManager.LoadScene ("Level_03_Snow");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 14 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			SceneManager.LoadScene ("Level_04_Snow");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 15 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			SceneManager.LoadScene ("Level_05_Snow");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 16 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			SceneManager.LoadScene ("Level_06_Snow");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 17 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			SceneManager.LoadScene ("Level_07_Snow");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 18 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			SceneManager.LoadScene ("Level_08_Snow");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 19 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			SceneManager.LoadScene ("Level_09_Snow");
		if (PlayerPrefs.GetInt ("block-breaker-current-level") == 20 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow")
			SceneManager.LoadScene ("Level_10_Snow");
	}

	void Update() {
		// Handle game paused here
		if (Input.GetKeyDown (KeyCode.Escape)) {
			// Change time scale
			Time.timeScale = 0f;
			PlayerPrefs.SetString ("block-breaker-paused", "true");
		}
	}
}
