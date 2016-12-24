using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Loads and quits scenes
/// </summary>
public class LevelManager : MonoBehaviour {

	// Load scenes
	public void LoadLevel(string name) {
		Application.LoadLevel (name);
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
