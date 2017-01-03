using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FXVolumeSlider : MonoBehaviour {

	public Slider volumeSlider;

	void Awake () {
		volumeSlider.minValue = 0f;
		volumeSlider.maxValue = 1f;
		volumeSlider.value = MusicPlayer.FXVolume;
	}
	
	// Update is called once per frame
	void Update () {

		MusicPlayer.FXVolume = volumeSlider.value;
		PlayerPrefs.SetFloat ("block-breaker-fx-volume", volumeSlider.value);
	}
}
