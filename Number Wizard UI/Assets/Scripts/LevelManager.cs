using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is focused on loading scenes only
/// </summary>
public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Application.LoadLevel (name);
	}

	public void QuitRequest() {
		Application.Quit ();
	}
}
