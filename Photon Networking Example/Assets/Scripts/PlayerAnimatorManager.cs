using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.asianinvasion.PhotonNetworkingExample {
	public class PlayerAnimatorManager : Photon.MonoBehaviour {

		private Animator animator;
		public float DirectionDampTime = 0.20f;

		#region MonoBehavior Callbacks
		void Start () {
			animator = gameObject.GetComponent<Animator> ();
			if(!animator) {
				Debug.LogError ("PlayerAnimatorManager is missing an Animator Component", this);
			}
		}

		void Update () {

			// All players on network have the same prefab, so there needs to be a way to choose the local one
			// If not the local player, then don't take in any inputs
			if (photonView.isMine == false && PhotonNetwork.connected == true)
				return;

			// Only jump when running
			AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

			// Run is in Base Layer, ask for current state
			if (stateInfo.IsName ("Base Layer.Run")) {
				if (Input.GetButtonDown("Fire2"))
					animator.SetTrigger ("Jump");
			}


			if (!animator)
				return;

			// Read user input
			float horiz = Input.GetAxis("Horizontal");
			float vert = Input.GetAxis ("Vertical");

			// No backwards movement
			if (vert < 0)
				vert = 0;

			animator.SetFloat ("Speed", vert * vert);
			animator.SetFloat ("Direction", horiz, DirectionDampTime, Time.deltaTime);
		}
		#endregion
	}
}
