using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.asianinvasion.PhotonNetworkingExample {
	public class Launcher : Photon.PunBehaviour {

		#region Public Variables
		/// <summary>
		/// The PUN loglevel
		/// </summary>
		public PhotonLogLevel LogLevel = PhotonLogLevel.Informational;

		/// <summary>
		/// The max players per room. If the room is full, players can't join, and a new room will be created.
		/// </summary>
		public byte MaxPlayersPerRoom = 4;

		[Tooltip("The UI Panel to let the user enter their name, connect, and play")]
		public GameObject controlPanel;
		[Tooltip("UI Label to inform the user that a connection is in process")]
		public GameObject progressLabel;
		#endregion


		#region Private Variables
		/// <summary>
		/// Client's user number. Users are separated by game version.
		/// </summary>
		string _gameVersion = "1";

		// Keep track of asynchronous processes by Photon
		bool isConnecting;
		#endregion

		#region MonoBehavior Callbacks
		void Awake() {

			// No need to join lobby to get the list of rooms
			PhotonNetwork.autoJoinLobby = false;

			// Allow use of PhotonNetwork.LoadLevel() on the master client
			// Make sure all clients in the same room sync their level automatically
			PhotonNetwork.automaticallySyncScene = true;

			// Not very important: Forces loglevel
			PhotonNetwork.logLevel = LogLevel;
		}

		void Start() {

			// Run Connect method to auto connect
			/*Connect ();*/
			controlPanel.SetActive (true);
			progressLabel.SetActive (false);
		}
		#endregion


		#region Public Methods
		/// <summary>
		/// Starts the connection process.
		/// If already connected, attempt to join a random room.
		/// If not already connected, then connect app to Photon Cloud Network
		/// </summary>
		public void Connect() {
			isConnecting = true;

			progressLabel.SetActive(true);
			controlPanel.SetActive(false);

			// If connected, then join a random room
			if(PhotonNetwork.connected) {
				// Join a random room. Will be notified if fails
				PhotonNetwork.JoinRandomRoom ();
			}
			// Else connect to Photon Online Server -> this is run before all PUN callbacks
			else {
				PhotonNetwork.ConnectUsingSettings (_gameVersion);
			}
		}
		#endregion

		/// <summary>
		/// Called after the connection to the master is established and authenticated but only when
		/// PhotonNetwork.autoJoinLobby is false.
		/// </summary>
		/// <remarks>If you set PhotonNetwork.autoJoinLobby to true, OnJoinedLobby() will be called instead of this.
		/// 
		/// You can join rooms and create them even without being in a lobby. The default lobby is used in that case.
		/// The list of available rooms won't become available unless you join a lobby via PhotonNetwork.joinLobby.</remarks>
		#region Photon.PunBehavior Callbacks
		public override void OnConnectedToMaster() {

			// Call only if the button is pressed, since when you return from the game to the lobby,
			// you disconnect from the game server and join the master server again
			if(isConnecting) {
				Debug.Log ("Connected to the Master Server");

				// Attempt to join a potential existing room.
				// If no room, callback with OnPhotonRandomJoinFailed()
				PhotonNetwork.JoinRandomRoom();
			}
		}

		public override void OnDisconnectedFromPhoton() {
			Debug.LogWarning("Disconnected from Photon Server"); 

			progressLabel.SetActive(false);
			controlPanel.SetActive(true);
		}

		public override void OnPhotonRandomJoinFailed(object[] codeAndMsg) {
			Debug.Log("No random room available, so we create one.\nCalling: PhotonNetwork.CreateRoom(null, new RoomOptions() {MaxPlayers = MaxPLayersPerRoom}, null);");

			// Create a room when failed to join a random room
			PhotonNetwork.CreateRoom(null, new RoomOptions() { MaxPlayers = MaxPlayersPerRoom }, null);
		}

		public override void OnJoinedRoom() {
			Debug.Log("Entered room");

			// Only the 1st player loads -> else use PhotonNetwork.automaticallySyncScene
			if(PhotonNetwork.room.PlayerCount == 1) {

				// Load room level
				PhotonNetwork.LoadLevel("Room for 1");
			}
		}
		#endregion
	}
}
