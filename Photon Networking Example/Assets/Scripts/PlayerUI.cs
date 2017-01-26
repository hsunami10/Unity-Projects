using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Com.asianinvasion.PhotonNetworkingExample {
	public class PlayerUI : MonoBehaviour {

		public Text PlayerNameText;
		public Slider PlayerHealthSlider;
		[Tooltip("Pixel offset from the player target")]
		public Vector3 ScreenOffset = new Vector3(0f,30f,0f);

		private PlayerManager _target;
		float _characterControllerHeight = 0f;
		Transform _targetTransform;
		Vector3 _targetPosition;

		#region Monobehaviour Callbacks
		void Awake() {
			// Always add UI as a child of the Canvas
			this.GetComponent<Transform>().SetParent (GameObject.Find("Canvas").GetComponent<Transform>());
		}

		// Update is called once per frame
		void Update () {

			// Update slider with target health
			if (PlayerHealthSlider != null)
				PlayerHealthSlider.value = _target.Health;

			// Delete when player is gone
			if(_target == null) {
				Destroy (gameObject);
				return;
			}
		}
		#endregion

		#region Public Methods
		// Take the nickname of the owner of that photonView
		public void SetTarget(PlayerManager target) {
			if (target == null)
				return;
			// Cache (store) reference of player for efficiency
			_target = target;

			CharacterController _characterController = _target.GetComponent<CharacterController> ();
			// Get data from the Player that won't change during the lifetime of this Component
			if (_characterController != null){
				_characterControllerHeight = _characterController.height;
			}

			if (PlayerNameText != null)
				PlayerNameText.text = _target.photonView.owner.NickName;
		}

		void LateUpdate () {
			// #Critical
			// Follow the Target GameObject on screen.
			if (_targetTransform!=null) {
				_targetPosition = _targetTransform.position;
				_targetPosition.y += _characterControllerHeight;
				this.transform.position = Camera.main.WorldToScreenPoint (_targetPosition) + ScreenOffset;
			}
		}
		#endregion
	}
}