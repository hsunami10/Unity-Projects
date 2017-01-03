using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Continue playing the background music throughout the whole game using DontDestroyOnLoad
/// Make it adjustable -> connected with Slider
/// </summary>
public class MusicPlayer : MonoBehaviour {

	// Can use AudioSource.PlayClipAtPoint(AudioClip clip, Vector3 position, float volume)
	
	static MusicPlayer instance = null;
	public static float backgroundVolume;
	public static float FXVolume;
	public Ball ball;

	// Runs before Start()
	void Awake() {

		// Initial background volume - default 0.5f
		if (PlayerPrefs.HasKey ("block-breaker-background-volume"))
			backgroundVolume = PlayerPrefs.GetFloat ("block-breaker-background-volume");
		else {
			PlayerPrefs.SetFloat ("block-breaker-background-volume", .5f);
			backgroundVolume = PlayerPrefs.GetFloat ("block-breaker-background-volume");
		}

		// Initial FX volume - default 0.5f
		if (PlayerPrefs.HasKey ("block-breaker-fx-volume"))
			FXVolume = PlayerPrefs.GetFloat ("block-breaker-fx-volume");
		else {
			PlayerPrefs.SetFloat ("block-breaker-fx-volume", .5f);
			FXVolume = PlayerPrefs.GetFloat ("block-breaker-fx-volume");
		}

		// Singleton Pattern
		if (instance != null)
			Destroy (gameObject);
		else {

			// Set MusicPlayer object (instance) to the current MusicPlayer
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	void Update() {
		
		// Set volume to the background volume
		gameObject.GetComponent<AudioSource> ().volume = backgroundVolume;
		ball.audio [0].volume = FXVolume;
		ball.audio [1].volume = FXVolume;
		ball.audio [2].volume = FXVolume;
	}
}
