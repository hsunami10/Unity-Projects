using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeatLevelTitle : MonoBehaviour {

	public Text text;
	private string environment;
	private int levelNum;

	void Awake() {

		// Checks which level was beaten, then adjust the mesage accordingly
		if(PlayerPrefs.GetInt ("block-breaker-current-level") == 1 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest") {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level");
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 1);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 2 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest") {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level");
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 2);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 3 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest") {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level");
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 3);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 4 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest") {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level");
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 4);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 5 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest") {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level");
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 5);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 6 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest") {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level");
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 6);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 7 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest") {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level");
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 7);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 8 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest") {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level");
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 8);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 9 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest") {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level");
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 9);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 10 && PlayerPrefs.GetString ("block-breaker-current-environment") == "forest") {
			environment = "forest";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level");
			PlayerPrefs.SetInt ("block-breaker-beat-forest-level", 10);
		}
	}

	// Use this for initialization
	void Start () {
		text.text = "CONGRATULATIONS ON BEATING " + environment.ToUpper() + " LEVEL " + levelNum.ToString();
	}
}
