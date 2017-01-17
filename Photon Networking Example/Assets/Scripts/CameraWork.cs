using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.asianinvasion.PhotonNetworkingExample {
	/// <summary>
	/// Makes the camera follow the player at all times
	/// </summary>
	public class CameraWork : MonoBehaviour {

		#region Public Properties
		[Tooltip("The distance from xz plane to player")]
		public float distance = 7f;

		[Tooltip("Height above player")]
		public float height = 3f;

		[Tooltip("Smooth time lag for height of camera")]
		public float heightSmoothLag = 0.3f;

		[Tooltip("Allow the camera to be offset vertically from player")]
		public Vector3 centerOffSet = Vector3.zero;

		[Tooltip("Set to false if an object is still being instantiated")]
		public bool followOnStart = false;
		#endregion


		#region Private Properties

		// Cached (stored) transform of target -> in OnStartFollowing
		private Transform cameraTransform;

		// Follow player if camera switched/player lost
		private bool isFollowing;

		// Current velocity, modified by SmoothDamp()
		private float heightVelocity = 0.0f;

		// Position
		private float targetHeight = 100000.0f;
		#endregion


		#region MonoBehaviour Callbacks
		void Start () {
			if (followOnStart)
				OnStartFollowing ();
		}
		/// <summary>
		/// Called after all Updates are called
		/// </summary>
		void LateUpdate () {
			// Old transform doesn't destroy on level load
			// Cover cases when main camera is different every scene, reconnect when it is
			if (cameraTransform == null && isFollowing)
				OnStartFollowing ();
			if (isFollowing)
				Apply ();
		}
		#endregion

		public void OnStartFollowing() {
			
			// Store the main camera's transform
			cameraTransform = Camera.main.transform;
			isFollowing = true;

			Cut ();
		}

		#region Private Methods
		/// <summary>
		/// Follow target smoothly
		/// </summary>
		void Apply() {
			Vector3 targetCenter = transform.position + centerOffSet;

			// Calculate the current & player rotation angles
			float originalTargetAngle = transform.eulerAngles.y;
			float currentAngle = cameraTransform.eulerAngles.y;


			// Adjust real target angle when camera is locked
			float targetAngle = originalTargetAngle;
			currentAngle = targetAngle;
			targetHeight = targetCenter.y + height;


			// Damp the height
			float currentHeight = cameraTransform.position.y;
			currentHeight = Mathf.SmoothDamp( currentHeight, targetHeight, ref heightVelocity, heightSmoothLag );


			// Convert the angle into a rotation, by which we then reposition the camera
			Quaternion currentRotation = Quaternion.Euler( 0, currentAngle, 0 );


			// Set the position of the camera on the x-z plane to:
			// distance meters behind the target
			cameraTransform.position = targetCenter;
			cameraTransform.position += currentRotation * Vector3.back * distance;

			// Set the height of the camera
			cameraTransform.position = new Vector3( cameraTransform.position.x, currentHeight, cameraTransform.position.z );

			// Always look at the target    
			SetUpRotation(targetCenter);
		}


		/// <summary>
		/// Directly position the camera to a the specified Target and center.
		/// </summary>
		void Cut()
		{
			float oldHeightSmooth = heightSmoothLag;
			heightSmoothLag = 0.001f;

			Apply();

			heightSmoothLag = oldHeightSmooth;
		}

		/// <summary>
		/// Sets up the rotation of the camera to always be behind the target
		/// </summary>
		void SetUpRotation( Vector3 centerPos )
		{
			Vector3 cameraPos = cameraTransform.position;
			Vector3 offsetToCenter = centerPos - cameraPos;

			// Generate base rotation only around y-axis
			// Take difference in camera and player position
			Quaternion yRotation = Quaternion.LookRotation(new Vector3(offsetToCenter.x, 0,offsetToCenter.z));

			// Offset +z (7) and -y (-3) directions
			Vector3 relativeOffset = Vector3.forward * distance + Vector3.down * height;
			cameraTransform.rotation = yRotation * Quaternion.LookRotation(relativeOffset);
		}
		#endregion
	}
}
