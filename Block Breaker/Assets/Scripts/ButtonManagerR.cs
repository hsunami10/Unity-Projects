using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Copy of ButtonManager
/// </summary>

public class ButtonManagerR : MonoBehaviour {

	public Text text;
	public static bool clicked;
	private int rightControl;

	void Awake() {
		clicked = false;

		if (!PlayerPrefs.HasKey("block-breaker-right-control")) {
			
			// If does not exist, then set to default value
			PlayerPrefs.SetString ("block-breaker-right-control-text", "RIGHT ARROW");
			text.text = "RIGHT ARROW";
			rightControl = (int)KeyCode.RightArrow;
			PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
		}
		else {
			// If it does exist, get the last control setting -> saves controls between scenes
			text.text = PlayerPrefs.GetString ("block-breaker-right-control-text");
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
				PlayerPrefs.SetString ("block-breaker-right-control-text", "UP ARROW");
				text.text = "UP ARROW";
				rightControl = (int)KeyCode.UpArrow;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.DownArrow)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "DOWN ARROW");
				text.text = "DOWN ARROW";
				rightControl = (int)KeyCode.DownArrow;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "right ARROW");
				text.text = "right ARROW";
				rightControl = (int)KeyCode.LeftArrow;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "RIGHT ARROW");
				text.text = "RIGHT ARROW";
				rightControl = (int)KeyCode.RightArrow;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}

			// Number Pad
			if (Input.GetKeyUp (KeyCode.Home)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "HOME");
				text.text = "HOME";
				rightControl = (int)KeyCode.Home;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.End)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "END");
				text.text = "END";
				rightControl = (int)KeyCode.End;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.PageUp)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "PAGE UP");
				text.text = "PAGE UP";
				rightControl = (int)KeyCode.PageUp;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.PageDown)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "PAGE DOWN");
				text.text = "PAGE DOWN";
				rightControl = (int)KeyCode.PageDown;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Numlock)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM LOCK");
				text.text = "NUM LOCK";
				rightControl = (int)KeyCode.Numlock;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadDivide)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "/");
				text.text = "/";
				rightControl = (int)KeyCode.KeypadDivide;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadMultiply)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "*");
				text.text = "*";
				rightControl = (int)KeyCode.KeypadMultiply;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadMinus)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "-");
				text.text = "-";
				rightControl = (int)KeyCode.KeypadMinus;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadPlus)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "+");
				text.text = "+";
				rightControl = (int)KeyCode.KeypadPlus;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadEnter)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "ENTER");
				text.text = "ENTER";
				rightControl = (int)KeyCode.KeypadEnter;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.KeypadPeriod)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", ".");
				text.text = ".";
				rightControl = (int)KeyCode.KeypadPeriod;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad0)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUMPAD0");
				text.text = "NUMPAD0";
				rightControl = (int)KeyCode.Keypad0;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad1)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUMPAD1");
				text.text = "NUMPAD1";
				rightControl = (int)KeyCode.Keypad1;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad2)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUMPAD2");
				text.text = "NUMPAD2";
				rightControl = (int)KeyCode.Keypad2;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad3)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUMPAD3");
				text.text = "NUMPAD3";
				rightControl = (int)KeyCode.Keypad3;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad4)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUMPAD4");
				text.text = "NUMPAD4";
				rightControl = (int)KeyCode.Keypad4;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad5)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUMPAD5");
				text.text = "NUMPAD5";
				rightControl = (int)KeyCode.Keypad5;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad6)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUMPAD6");
				text.text = "NUMPAD6";
				rightControl = (int)KeyCode.Keypad6;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad7)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUMPAD7");
				text.text = "NUMPAD7";
				rightControl = (int)KeyCode.Keypad7;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad8)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUMPAD8");
				text.text = "NUMPAD8";
				rightControl = (int)KeyCode.Keypad8;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Keypad9)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUMPAD9");
				text.text = "NUMPAD9";
				rightControl = (int)KeyCode.Keypad9;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}

			// Top row
			if (Input.GetKeyUp (KeyCode.Insert)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "INS");
				text.text = "INS";
				rightControl = (int)KeyCode.Insert;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Delete)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "DELETE");
				text.text = "DELETE";
				rightControl = (int)KeyCode.Delete;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}

			// Second top row
			if (Input.GetKeyUp (KeyCode.BackQuote)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "`");
				text.text = "`";
				rightControl = (int)KeyCode.BackQuote;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha0)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM0");
				text.text = "NUM0";
				rightControl = (int)KeyCode.Alpha0;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha1)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM1");
				text.text = "NUM1";
				rightControl = (int)KeyCode.Alpha1;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha2)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM2");
				text.text = "NUM2";
				rightControl = (int)KeyCode.Alpha2;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha3)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM3");
				text.text = "NUM3";
				rightControl = (int)KeyCode.Alpha3;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha4)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM4");
				text.text = "NUM4";
				rightControl = (int)KeyCode.Alpha4;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha5)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM5");
				text.text = "NUM5";
				rightControl = (int)KeyCode.Alpha5;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha6)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM6");
				text.text = "NUM6";
				rightControl = (int)KeyCode.Alpha6;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha7)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM7");
				text.text = "NUM7";
				rightControl = (int)KeyCode.Alpha7;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha8)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM8");
				text.text = "NUM8";
				rightControl = (int)KeyCode.Alpha8;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Alpha9)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "NUM9");
				text.text = "NUM9";
				rightControl = (int)KeyCode.Alpha9;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Minus)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "-");
				text.text = "-";
				rightControl = (int)KeyCode.Minus;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Equals)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "=");
				text.text = "=";
				rightControl = (int)KeyCode.Equals;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Backspace)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "BACKSPACE");
				text.text = "BACKSPACE";
				rightControl = (int)KeyCode.Backspace;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}

			// Third top row
			if (Input.GetKeyUp (KeyCode.Tab)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "TAB");
				text.text = "TAB";
				rightControl = (int)KeyCode.Tab;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Q)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "Q");
				text.text = "Q";
				rightControl = (int)KeyCode.Q;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.W)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "W");
				text.text = "W";
				rightControl = (int)KeyCode.W;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.E)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "E");
				text.text = "E";
				rightControl = (int)KeyCode.E;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.R)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "R");
				text.text = "R";
				rightControl = (int)KeyCode.R;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.T)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "T");
				text.text = "T";
				rightControl = (int)KeyCode.T;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Y)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "Y");
				text.text = "Y";
				rightControl = (int)KeyCode.Y;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.U)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "U");
				text.text = "U";
				rightControl = (int)KeyCode.U;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.I)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "I");
				text.text = "I";
				rightControl = (int)KeyCode.I;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.O)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "O");
				text.text = "O";
				rightControl = (int)KeyCode.O;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.P)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "P");
				text.text = "P";
				rightControl = (int)KeyCode.P;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.LeftBracket)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "[");
				text.text = "[";
				rightControl = (int)KeyCode.LeftBracket;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightBracket)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "]");
				text.text = "]";
				rightControl = (int)KeyCode.RightBracket;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Backslash)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "\\");
				text.text = "\\";
				rightControl = (int)KeyCode.Backslash;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}

			// 4th top row
			if (Input.GetKeyUp (KeyCode.A)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "A");
				text.text = "A";
				rightControl = (int)KeyCode.A;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.S)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "S");
				text.text = "S";
				rightControl = (int)KeyCode.S;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.D)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "D");
				text.text = "D";
				rightControl = (int)KeyCode.D;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.F)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "F");
				text.text = "F";
				rightControl = (int)KeyCode.F;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.G)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "G");
				text.text = "G";
				rightControl = (int)KeyCode.G;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.H)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "H");
				text.text = "H";
				rightControl = (int)KeyCode.H;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.J)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "J");
				text.text = "J";
				rightControl = (int)KeyCode.J;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.K)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "K");
				text.text = "K";
				rightControl = (int)KeyCode.K;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.L)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "L");
				text.text = "L";
				rightControl = (int)KeyCode.L;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Semicolon)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", ";");
				text.text = ";";
				rightControl = (int)KeyCode.Semicolon;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Quote)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "'");
				text.text = "'";
				rightControl = (int)KeyCode.Quote;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Return)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "RETURN");
				text.text = "RETURN";
				rightControl = (int)KeyCode.Return;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}

			// 5th top row
			if (Input.GetKeyUp (KeyCode.LeftShift)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "SHIFT");
				text.text = "SHIFT";
				rightControl = (int)KeyCode.LeftShift;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Z)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "Z");
				text.text = "Z";
				rightControl = (int)KeyCode.Z;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.X)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "X");
				text.text = "X";
				rightControl = (int)KeyCode.X;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.C)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "C");
				text.text = "C";
				rightControl = (int)KeyCode.C;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.V)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "V");
				text.text = "V";
				rightControl = (int)KeyCode.V;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.B)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "B");
				text.text = "B";
				rightControl = (int)KeyCode.B;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.N)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "N");
				text.text = "N";
				rightControl = (int)KeyCode.N;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.M)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "M");
				text.text = "M";
				rightControl = (int)KeyCode.M;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Comma)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", ",");
				text.text = ",";
				rightControl = (int)KeyCode.Comma;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Period)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", ".");
				text.text = ".";
				rightControl = (int)KeyCode.Period;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.Slash)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "/");
				text.text = "/";
				rightControl = (int)KeyCode.Slash;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightShift)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "SHIFT");
				text.text = "SHIFT";
				rightControl = (int)KeyCode.RightShift;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}

			// Bottom row
			if (Input.GetKeyUp (KeyCode.LeftControl)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "CONTROL");
				text.text = "CONTROL";
				rightControl = (int)KeyCode.LeftControl;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.LeftAlt)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "ALT");
				text.text = "ALT";
				rightControl = (int)KeyCode.LeftAlt;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.LeftCommand)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "COMMAND");
				text.text = "COMMAND";
				rightControl = (int)KeyCode.LeftCommand;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightControl)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "CONTROL");
				text.text = "CONTROL";
				rightControl = (int)KeyCode.RightControl;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightAlt)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "ALT");
				text.text = "ALT";
				rightControl = (int)KeyCode.RightAlt;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
			if (Input.GetKeyUp (KeyCode.RightCommand)) {
				PlayerPrefs.SetString ("block-breaker-right-control-text", "COMMAND");
				text.text = "COMMAND";
				rightControl = (int)KeyCode.RightCommand;
				PlayerPrefs.SetInt ("block-breaker-right-control", rightControl);
				clicked = false;
			}
		}
	}
}
