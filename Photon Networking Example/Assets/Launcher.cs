using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.asianinvasion.BOAT {
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
		#endregion


		#region Private Variables
		/// <summary>
		/// Client's user number. Users are separated by game version.
		/// </summary>
		string _gameVersion = "1";
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

			// Run Connect method
			Connect ();
		}
		#endregion


		#region Public Methods
		/// <summary>
		/// Starts the connection process.
		/// If already connected, attempt to join a random room.
		/// If not already connected, then connect app to Photon Cloud Network
		/// </summary>
		public void Connect() {

			// If connected, then join a random room
			if(PhotonNetwork.connected) {
				// Join a random room. Will be notified if fails
				PhotonNetwork.JoinRandomRoom ();
			}
			// Else connect to Photon Online Server
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
			Debug.Log ("DemoAnimator/Launcher: OnConnectedToMaster() was called by PUN");

			// Attempt to join a potential existing room.
			// If no room, callback with OnPhotonRandomJoinFailed()
			PhotonNetwork.JoinRandomRoom();
		}

		public override void OnDisconnectedFromPhoton() {
			Debug.LogWarning("DemoAnimator/Launcher: OnDisconnectedFromPhoton() was called by PUN"); 
		}

		public override void OnPhotonRandomJoinFailed(object[] codeAndMsg) {
			Debug.Log("DemoAnimator/Launcher:OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one.\nCalling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);");

			// Create a room when failed to join a random room
			PhotonNetwork.CreateRoom(null, new RoomOptions() { maxPlayers = MaxPlayersPerRoom }, null);
		}

		public override void OnJoinedRoom() {
			Debug.Log("DemoAnimator/Launcher: OnJoinedRoom() called by PUN. Now this client is in a room.");
		}
		#endregion
	}
}
