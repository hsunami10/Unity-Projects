using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Button> ().interactable = false;
	}
	
	// Update is called once per frame
	void Update () {

		// Enable button once all levels in forest have been beaten
		if(PlayerPrefs.GetString("block-breaker-beat-all-forest") == "true")
			gameObject.GetComponent<Button> ().interactable = true;
	}
}
