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

		// Forest
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
			PlayerPrefs.SetString ("block-breaker-beat-all-forest", "true");
		}

		// Snow
		else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 11 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow") {
			environment = "snow";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level") - 10;
			PlayerPrefs.SetInt ("block-breaker-beat-snow-level", 1);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 12 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow") {
			environment = "snow";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level") - 10;
			PlayerPrefs.SetInt ("block-breaker-beat-snow-level", 2);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 13 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow") {
			environment = "snow";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level") - 10;
			PlayerPrefs.SetInt ("block-breaker-beat-snow-level", 3);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 14 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow") {
			environment = "snow";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level") - 10;
			PlayerPrefs.SetInt ("block-breaker-beat-snow-level", 4);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 15 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow") {
			environment = "snow";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level") - 10;
			PlayerPrefs.SetInt ("block-breaker-beat-snow-level", 5);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 16 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow") {
			environment = "snow";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level") - 10;
			PlayerPrefs.SetInt ("block-breaker-beat-snow-level", 6);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 17 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow") {
			environment = "snow";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level") - 10;
			PlayerPrefs.SetInt ("block-breaker-beat-snow-level", 7);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 18 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow") {
			environment = "snow";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level") - 10;
			PlayerPrefs.SetInt ("block-breaker-beat-snow-level", 8);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 19 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow") {
			environment = "snow";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level") - 10;
			PlayerPrefs.SetInt ("block-breaker-beat-snow-level", 9);
		} else if(PlayerPrefs.GetInt ("block-breaker-current-level") == 20 && PlayerPrefs.GetString ("block-breaker-current-environment") == "snow") {
			environment = "snow";
			levelNum = PlayerPrefs.GetInt ("block-breaker-current-level") - 10;
			PlayerPrefs.SetInt ("block-breaker-beat-snow-level", 10);
		}
	}

	// Use this for initialization
	void Start () {
		text.text = "CONGRATULATIONS ON BEATING " + environment.ToUpper() + " LEVEL " + levelNum.ToString();

		// When first time playing game, the player has to start at forest level 1
		// Forest
		if (!PlayerPrefs.HasKey ("block-breaker-beat-highest-forest-level"))
			PlayerPrefs.SetInt ("block-breaker-beat-highest-forest-level", 1);
		else if (PlayerPrefs.GetInt ("block-breaker-beat-forest-level") > PlayerPrefs.GetInt ("block-breaker-beat-highest-forest-level"))
			PlayerPrefs.SetInt ("block-breaker-beat-highest-forest-level", PlayerPrefs.GetInt ("block-breaker-beat-forest-level"));

		// Snow - first beaten level is level 1
		if (!PlayerPrefs.HasKey ("block-breaker-beat-highest-snow-level"))
			PlayerPrefs.SetInt ("block-breaker-beat-highest-snow-level", 1);
		else if (PlayerPrefs.GetInt ("block-breaker-beat-snow-level") > PlayerPrefs.GetInt ("block-breaker-beat-highest-snow-level"))
			PlayerPrefs.SetInt ("block-breaker-beat-highest-snow-level", PlayerPrefs.GetInt ("block-breaker-beat-snow-level"));
	}
}
