using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Continue playing the background music throughout the whole game using DontDestroyOnLoad
/// </summary>
public class MusicPlayer : MonoBehaviour {
	
	static MusicPlayer instance = null;

	// Runs before Start()
	void Awake() {

		// Singleton Pattern
		if (instance != null)
			Destroy (gameObject);
		else {

			// Set MusicPlayer object (instance) to the current MusicPlayer
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}
	
	// Use this for initialization
	void Start() {
		
	}
}
