using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Com.asianinvasion.PhotonNetworkingExample {
	/// <summary>
	/// Runs when in a room. Manages player connections and disconnections in room
	/// </summary>
	public class GameManager : Photon.PunBehaviour {

		#region Public Variables
		public static GameManager instance;
		public GameObject playerPrefab;
		#endregion

		void Start() {

			// Restrict instantiation of class to static instance object (singleton)
			instance = this;

			// When in room, spawn local player
			// Don't repeatly instantiate when a new room is loaded
			if(PlayerManager.LocalPlayerInstance == null)
				PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(0, 5f, 0), Quaternion.identity, 0);
		}

		#region Photon Messages
		/// <summary>
		/// Called when the local player leaves the room.
		/// Loads the launcher scene
		/// </summary>
		public override void OnLeftRoom() {
			SceneManager.LoadScene ("Launcher");
		}

		// When a player connects, load the corresponding room
		public override void OnPhotonPlayerConnected(PhotonPlayer other) {
			// Not seen if you're the player connecting
			Debug.Log( "OnPhotonPlayerConnected() " + other.NickName ); 

			if (PhotonNetwork.isMasterClient) {
				// Called before OnPhotonPlayerDisconnected
				Debug.Log( "OnPhotonPlayerConnected isMasterClient " + PhotonNetwork.isMasterClient );
				LoadArena();
			}
		}

		public override void OnPhotonPlayerDisconnected(PhotonPlayer other) {
			// Seen when other disconnects
			Debug.Log( "OnPhotonPlayerDisconnected() " + other.NickName );

			if ( PhotonNetwork.isMasterClient) {
				Debug.Log( "OnPhotonPlayerDisconnected isMasterClient " + PhotonNetwork.isMasterClient );
				LoadArena();
			}
		}
		#endregion


		#region Private Methods
		void LoadArena() {

			// PhotonNetwork.LoadLevel should only be called in the master server
			if(!PhotonNetwork.isMasterClient) {
				Debug.LogError( "PhotonNetwork : Trying to Load a level but we are not the master Client" );
			}
			Debug.Log( "PhotonNetwork : Loading Level : " + PhotonNetwork.room.PlayerCount );

			// Load level on all connected clients of the room
			PhotonNetwork.LoadLevel("Room for " + PhotonNetwork.room.PlayerCount);
		}
		#endregion


		#region Public Methods
		public void LeaveRoom() {
			PhotonNetwork.LeaveRoom ();
		}
		#endregion
	}
}