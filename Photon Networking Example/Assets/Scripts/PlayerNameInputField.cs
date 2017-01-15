using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.asianinvasion.PhotonNetworkingExample {

	/// <summary>
	/// Player name input field. Let the user enter their name, and it will appear above them in game
	/// </summary>

	// Always adds component to current game object
	[RequireComponent(typeof(InputField))]
	public class PlayerNameInputField : MonoBehaviour {

		#region Private Variables
		// Store the PlayerPref key
		static string playerNamePrefKey = "PlayerName";
		#endregion


		#region MonoBehavior Callbacks
		void Start () {

			string defaultName = "";
			InputField _inputField = gameObject.GetComponent<InputField> ();

			if(_inputField != null) {

				// If a name already exists, then set the input field text to that name
				if(PlayerPrefs.HasKey(playerNamePrefKey)) {
					defaultName = PlayerPrefs.GetString (playerNamePrefKey);
					_inputField.text = defaultName;
				}
			}

			PhotonNetwork.playerName = defaultName;
		}
		#endregion


		#region Public Methods
		/// <summary>
		/// Sets the name of the player, and saves it in PlayerPrefs
		/// </summary>
		/// <param name="value">Value.</param>
		public void SetPlayerName(string value) {

			// Forces trailing white space in case it's an empty string, so it updates
			PhotonNetwork.playerName = value + " ";

			PlayerPrefs.SetString (playerNamePrefKey, value);
		}
		#endregion
	}
}
