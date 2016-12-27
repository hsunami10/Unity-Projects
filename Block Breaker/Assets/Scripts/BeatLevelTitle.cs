using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeatLevelTitle : MonoBehaviour {

	public Text text;
	private string environment;
	private int levelNum;

	void Awake() {
		if(PlayerPrefs.GetInt("block-breaker-beat-forest-level") == 1) {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-beat-forest-level");
		}
	}

	// Use this for initialization
	void Start () {
		text.text = "CONGRATULATIONS ON BEATING " + environment.ToUpper () + " LEVEL " + levelNum.ToString();
	}
}
