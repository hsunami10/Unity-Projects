using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Loads and quits scenes
/// </summary>
public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Application.LoadLevel (name);
	}

	public void QuitRequest() {
		Application.Quit ();
	}
}
