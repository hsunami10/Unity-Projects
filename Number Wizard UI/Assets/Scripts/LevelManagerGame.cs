using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Load different scenes
/// </summary>
public class LevelManagerGame : MonoBehaviour {

	public void LoadLevel(string name) {
		Application.LoadLevel (name);
	}

}
