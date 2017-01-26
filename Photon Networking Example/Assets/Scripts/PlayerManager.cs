#if UNITY_5 && (!UNITY_5_0 && !UNITY_5_1 && !UNITY_5_2 && ! UNITY_5_3) || UNITY_6
#define UNITY_MIN_5_4
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Since there are multiple PlayerManager scripts running, photonView.isMine determines the local player

namespace Com.asianinvasion.PhotonNetworkingExample {
	/// <summary>
	/// PlayerManager handles firing beams
	/// </summary>
	/// IPunObservable allows the sending of data between local and network players
	public class PlayerManager : Photon.PunBehaviour, IPunObservable {

		#region Public Variables
		public GameObject beams;
		bool isFiring;
		public static GameObject LocalPlayerInstance;

		[Tooltip("Current health of player")]
		public float Health = 1f;

		public GameObject PlayerUIPrefab;
		#endregion

		void Awake() {
			beams.SetActive (false);

			// Keep track of game object creation for only ONE instantiation
			if (photonView.isMine)
				PlayerManager.LocalPlayerInstance = this.gameObject;

			// Don't destroy play when a new person enters the room
			DontDestroyOnLoad (this.gameObject);
		}

		#region Monobehaviour Callbacks
		void Start() {
			// Make camera only follow local player, since there are multple cameras
			CameraWork _cameraWork = gameObject.GetComponent<CameraWork> ();

			if(_cameraWork != null) {
				// If local player, then set camera to follow local player
				// All other players have photonView.isMine set to false
				if (photonView.isMine)
					_cameraWork.OnStartFollowing ();
			}

			// Reset players position when out of arena
			#if UNITY_MIN_5_4
			// Unity 5.4 has a new scene management. register a method to call CalledOnLevelWasLoaded.
			UnityEngine.SceneManagement.SceneManager.sceneLoaded += (scene, loadingMode) =>
			{
				this.CalledOnLevelWasLoaded(scene.buildIndex);
			};
			#endif

			if (PlayerUIPrefab != null) {
				GameObject _uiGo = Instantiate (PlayerUIPrefab) as GameObject;
				// Tells the gameobject's script to run method SetTarget with this instance as a parameter
				_uiGo.SendMessage ("SetTarget", this, SendMessageOptions.RequireReceiver);
			}
		}

		void Update() {
			// ONLY if local player, then allow inputs to fire beams
			if (photonView.isMine)
				ProcessInputs ();

			if (beams != null && isFiring != beams.GetActive ())
				beams.SetActive (isFiring);

			if (Health < 0) {
				// Class.static public variable. method
				GameManager.instance.LeaveRoom ();
			}
		}

		#if !UNITY_MIN_5_4
		/// <summary>See CalledOnLevelWasLoaded. Outdated in Unity 5.4.</summary>
		void OnLevelWasLoaded(int level)
		{
		this.CalledOnLevelWasLoaded(level);
		}
		#endif


		void CalledOnLevelWasLoaded(int level)
		{
			// If raycasting downward doesn't hit anything, spawn in the center of the room
			if (!Physics.Raycast(transform.position, -Vector3.up, 5f))
			{
				transform.position = new Vector3(0f, 5f, 0f);
			}

			// Player UI deleted when a new level was loaded, so instantiate again
			GameObject _uiGo = Instantiate(this.PlayerUIPrefab) as GameObject;
			_uiGo.SendMessage("SetTarget", this, SendMessageOptions.RequireReceiver);
		}
		#endregion

		/// <summary>
		/// Decrease player's health when beams hit it (initially)
		/// </summary>
		/// <param name="other">Other.</param>
		void OnTriggerEnter(Collider other) {

			// Don't do anything if the view is not the local player
			if (!photonView.isMine)
				return;

			// Decrease health only if player collides with beams
			if (other.tag != "Beams")
				return;

			Health -= 0.1f;
		}

		/// <summary>
		/// Decrease player's health when beams are continuously touching player
		/// </summary>
		/// <param name="other">Other.</param>
		void OnTriggerStay(Collider other) {

			// Only affect health of local player
			if (!photonView.isMine)
				return;
			
			if (other.tag != "Beams")
				return;

			// Decrease health according to how long it's in frame
			Health -= 0.1f * Time.deltaTime;
		}

		/// <summary>
		/// Fire when the button is held down
		/// </summary>
		void ProcessInputs() {
			if (Input.GetKey(KeyCode.Space))
				isFiring = true;
			else
				isFiring = false;
		}

		#region IPunObservable implementation

		/// <summary>
		/// Raises the photon serialize view event.
		/// Allows local player to send and receive data to and from network players
		/// Only called when observable by PhotonView
		/// </summary>
		/// <param name="stream">Stream.</param>
		/// <param name="info">Info.</param>
		void IPunObservable.OnPhotonSerializeView (PhotonStream stream, PhotonMessageInfo info)
		{
			// If true, add local player data to network and send
			if(stream.isWriting) {
				stream.SendNext (isFiring);
				stream.SendNext (Health);
			} else {
				// Read data from network players
				this.isFiring = (bool)stream.ReceiveNext();
				this.Health = (float)stream.ReceiveNext ();
			}
		}

		#endregion
	}
}
