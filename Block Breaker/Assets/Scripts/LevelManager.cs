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
}
