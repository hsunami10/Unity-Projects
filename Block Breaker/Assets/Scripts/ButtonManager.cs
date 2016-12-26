using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Cast int to enum
// KeyCode left = (KeyCode)leftControl;

/// <summary>
/// This allows the player to customize him/her own controls, and saves these controls into the computer
/// </summary>

public class ButtonManager : MonoBehaviour {

	public Text text;
	public static bool clicked;
	private int leftControl;

	void Awake() {
		clicked = false;

		if (!PlayerPrefs.HasKey("block-breaker-left-control")) {
			
			// If does not exist, then set to default value
			PlayerPrefs.SetString ("block-breaker-left-control-text", "LEFT ARROW");
			text.text = "LEFT ARROW";
			leftControl = (int)KeyCode.LeftArrow;
			PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
		}
		else {
			// If it does exist, get the last control setting -> saves controls between scenes
			text.text = PlayerPrefs.GetString ("block-breaker-left-control-text");
		}
	}

	public void ChangeControls() {
		clicked = true;
	}

	// Update is called once per frame
	void Update () {
		if(clicked) {
			
			// Arrow keys
			if (Input.GetKeyUp (KeyCode.UpArrow)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "UP ARROW");
				text.text = "UP ARROW";
				leftControl = (int)KeyCode.UpArrow;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.DownArrow)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "DOWN ARROW");
				text.text = "DOWN ARROW";
				leftControl = (int)KeyCode.DownArrow;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "LEFT ARROW");
				text.text = "LEFT ARROW";
				leftControl = (int)KeyCode.LeftArrow;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "RIGHT ARROW");
				text.text = "RIGHT ARROW";
				leftControl = (int)KeyCode.RightArrow;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}

			// Number Pad
			if (Input.GetKeyUp (KeyCode.Home)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "HOME");
				text.text = "HOME";
				leftControl = (int)KeyCode.Home;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.End)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "END");
				text.text = "END";
				leftControl = (int)KeyCode.End;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.PageUp)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "PAGE UP");
				text.text = "PAGE UP";
				leftControl = (int)KeyCode.PageUp;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.PageDown)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "PAGE DOWN");
				text.text = "PAGE DOWN";
				leftControl = (int)KeyCode.PageDown;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Numlock)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM LOCK");
				text.text = "NUM LOCK";
				leftControl = (int)KeyCode.Numlock;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadDivide)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "/");
				text.text = "/";
				leftControl = (int)KeyCode.KeypadDivide;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadMultiply)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "*");
				text.text = "*";
				leftControl = (int)KeyCode.KeypadMultiply;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadMinus)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "-");
				text.text = "-";
				leftControl = (int)KeyCode.KeypadMinus;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadPlus)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "+");
				text.text = "+";
				leftControl = (int)KeyCode.KeypadPlus;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "ENTER");
				text.text = "ENTER";
				leftControl = (int)KeyCode.KeypadEnter;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadPeriod)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", ".");
				text.text = ".";
				leftControl = (int)KeyCode.KeypadPeriod;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad0)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUMPAD0");
				text.text = "NUMPAD0";
				leftControl = (int)KeyCode.Keypad0;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad1)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUMPAD1");
				text.text = "NUMPAD1";
				leftControl = (int)KeyCode.Keypad1;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad2)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUMPAD2");
				text.text = "NUMPAD2";
				leftControl = (int)KeyCode.Keypad2;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad3)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUMPAD3");
				text.text = "NUMPAD3";
				leftControl = (int)KeyCode.Keypad3;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad4)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUMPAD4");
				text.text = "NUMPAD4";
				leftControl = (int)KeyCode.Keypad4;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad5)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUMPAD5");
				text.text = "NUMPAD5";
				leftControl = (int)KeyCode.Keypad5;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad6)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUMPAD6");
				text.text = "NUMPAD6";
				leftControl = (int)KeyCode.Keypad6;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad7)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUMPAD7");
				text.text = "NUMPAD7";
				leftControl = (int)KeyCode.Keypad7;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad8)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUMPAD8");
				text.text = "NUMPAD8";
				leftControl = (int)KeyCode.Keypad8;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad9)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUMPAD9");
				text.text = "NUMPAD9";
				leftControl = (int)KeyCode.Keypad9;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}

			// Top row
			if (Input.GetKeyUp (KeyCode.Insert)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "INS");
				text.text = "INS";
				leftControl = (int)KeyCode.Insert;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Delete)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "DELETE");
				text.text = "DELETE";
				leftControl = (int)KeyCode.Delete;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}

			// Second top row
			if (Input.GetKeyUp (KeyCode.BackQuote)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "`");
				text.text = "`";
				leftControl = (int)KeyCode.BackQuote;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha0)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM0");
				text.text = "NUM0";
				leftControl = (int)KeyCode.Alpha0;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha1)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM1");
				text.text = "NUM1";
				leftControl = (int)KeyCode.Alpha1;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha2)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM2");
				text.text = "NUM2";
				leftControl = (int)KeyCode.Alpha2;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha3)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM3");
				text.text = "NUM3";
				leftControl = (int)KeyCode.Alpha3;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha4)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM4");
				text.text = "NUM4";
				leftControl = (int)KeyCode.Alpha4;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha5)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM5");
				text.text = "NUM5";
				leftControl = (int)KeyCode.Alpha5;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha6)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM6");
				text.text = "NUM6";
				leftControl = (int)KeyCode.Alpha6;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha7)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM7");
				text.text = "NUM7";
				leftControl = (int)KeyCode.Alpha7;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha8)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM8");
				text.text = "NUM8";
				leftControl = (int)KeyCode.Alpha8;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha9)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "NUM9");
				text.text = "NUM9";
				leftControl = (int)KeyCode.Alpha9;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Minus)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "-");
				text.text = "-";
				leftControl = (int)KeyCode.Minus;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Equals)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "=");
				text.text = "=";
				leftControl = (int)KeyCode.Equals;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Backspace)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "BACKSPACE");
				text.text = "BACKSPACE";
				leftControl = (int)KeyCode.Backspace;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}

			// Third top row
			if (Input.GetKeyUp (KeyCode.Tab)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "TAB");
				text.text = "TAB";
				leftControl = (int)KeyCode.Tab;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Q)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "Q");
				text.text = "Q";
				leftControl = (int)KeyCode.Q;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.W)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "W");
				text.text = "W";
				leftControl = (int)KeyCode.W;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.E)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "E");
				text.text = "E";
				leftControl = (int)KeyCode.E;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.R)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "R");
				text.text = "R";
				leftControl = (int)KeyCode.R;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.T)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "T");
				text.text = "T";
				leftControl = (int)KeyCode.T;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Y)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "Y");
				text.text = "Y";
				leftControl = (int)KeyCode.Y;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.U)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "U");
				text.text = "U";
				leftControl = (int)KeyCode.U;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.I)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "I");
				text.text = "I";
				leftControl = (int)KeyCode.I;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.O)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "O");
				text.text = "O";
				leftControl = (int)KeyCode.O;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.P)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "P");
				text.text = "P";
				leftControl = (int)KeyCode.P;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.LeftBracket)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "[");
				text.text = "[";
				leftControl = (int)KeyCode.LeftBracket;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightBracket)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "]");
				text.text = "]";
				leftControl = (int)KeyCode.RightBracket;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Backslash)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "\\");
				text.text = "\\";
				leftControl = (int)KeyCode.Backslash;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}

			// 4th top row
			if (Input.GetKeyUp (KeyCode.A)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "A");
				text.text = "A";
				leftControl = (int)KeyCode.A;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.S)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "S");
				text.text = "S";
				leftControl = (int)KeyCode.S;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.D)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "D");
				text.text = "D";
				leftControl = (int)KeyCode.D;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "F");
				text.text = "F";
				leftControl = (int)KeyCode.F;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.G)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "G");
				text.text = "G";
				leftControl = (int)KeyCode.G;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.H)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "H");
				text.text = "H";
				leftControl = (int)KeyCode.H;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.J)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "J");
				text.text = "J";
				leftControl = (int)KeyCode.J;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.K)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "K");
				text.text = "K";
				leftControl = (int)KeyCode.K;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.L)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "L");
				text.text = "L";
				leftControl = (int)KeyCode.L;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Semicolon)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", ";");
				text.text = ";";
				leftControl = (int)KeyCode.Semicolon;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Quote)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "'");
				text.text = "'";
				leftControl = (int)KeyCode.Quote;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Return)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "RETURN");
				text.text = "RETURN";
				leftControl = (int)KeyCode.Return;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}

			// 5th top row
			if (Input.GetKeyUp (KeyCode.LeftShift)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "SHIFT");
				text.text = "SHIFT";
				leftControl = (int)KeyCode.LeftShift;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Z)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "Z");
				text.text = "Z";
				leftControl = (int)KeyCode.Z;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.X)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "X");
				text.text = "X";
				leftControl = (int)KeyCode.X;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.C)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "C");
				text.text = "C";
				leftControl = (int)KeyCode.C;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.V)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "V");
				text.text = "V";
				leftControl = (int)KeyCode.V;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.B)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "B");
				text.text = "B";
				leftControl = (int)KeyCode.B;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.N)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "N");
				text.text = "N";
				leftControl = (int)KeyCode.N;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.M)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "M");
				text.text = "M";
				leftControl = (int)KeyCode.M;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Comma)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", ",");
				text.text = ",";
				leftControl = (int)KeyCode.Comma;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Period)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", ".");
				text.text = ".";
				leftControl = (int)KeyCode.Period;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Slash)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "/");
				text.text = "/";
				leftControl = (int)KeyCode.Slash;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightShift)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "SHIFT");
				text.text = "SHIFT";
				leftControl = (int)KeyCode.RightShift;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}

			// Bottom row
			if (Input.GetKeyUp (KeyCode.LeftControl)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "CONTROL");
				text.text = "CONTROL";
				leftControl = (int)KeyCode.LeftControl;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.LeftAlt)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "ALT");
				text.text = "ALT";
				leftControl = (int)KeyCode.LeftAlt;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.LeftCommand)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "COMMAND");
				text.text = "COMMAND";
				leftControl = (int)KeyCode.LeftCommand;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightControl)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "CONTROL");
				text.text = "CONTROL";
				leftControl = (int)KeyCode.RightControl;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightAlt)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "ALT");
				text.text = "ALT";
				leftControl = (int)KeyCode.RightAlt;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightCommand)) {
				PlayerPrefs.SetString ("block-breaker-left-control-text", "COMMAND");
				text.text = "COMMAND";
				leftControl = (int)KeyCode.RightCommand;
				PlayerPrefs.SetInt ("block-breaker-left-control", leftControl);
				clicked = false;
			}
		}
	}
}
