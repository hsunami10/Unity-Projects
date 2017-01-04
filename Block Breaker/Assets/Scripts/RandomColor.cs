using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Changes text to a random color at certain time intervals
/// </summary>
public class RandomColor : MonoBehaviour {

	public float timer = 0.0f;
	public Text text;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		text.text = "Block Breaker";

		// Starting in 0 seconds, the color will change every 0.3001 seconds
		InvokeRepeating ("RandColor", 0.0f, 0.3001f);
	}

	void RandColor() {
		Color newColor = new Color (Random.value, Random.value, Random.value, 1.0f);
		text.color = newColor;
	}
}
