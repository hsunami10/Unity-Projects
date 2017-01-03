using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundVolumeSlider : MonoBehaviour {

	public Slider volumeSlider;

	void Awake() {
		volumeSlider.minValue = 0f;
		volumeSlider.maxValue = 1f;
		volumeSlider.value = MusicPlayer.backgroundVolume;
	}

	// Update is called once per frame
	void Update () {

		// Set background volume to the slider value
		MusicPlayer.backgroundVolume = volumeSlider.value;
		PlayerPrefs.SetFloat ("block-breaker-background-volume", volumeSlider.value);
	}
}
