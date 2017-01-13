using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour {

	public Slider slider;

	void Awake() {
		if (!PlayerPrefs.HasKey ("tilt sensitivity"))
			PlayerPrefs.SetFloat ("tilt sensitivity", 4f);
	}

	// Use this for initialization
	void Start () {
		slider.minValue = 1f;
		slider.maxValue = 8f;
		slider.value = PlayerPrefs.GetFloat("tilt sensitivity");
	}

	public void ValueChanged() {
		PlayerPrefs.SetFloat ("tilt sensitivity", slider.value);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
