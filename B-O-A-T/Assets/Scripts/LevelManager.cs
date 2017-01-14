using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	private Matrix4x4 calibrationMatrix;
	public Image sceneFade;

	void Awake() {
		
	}

	// Use this for initialization
	void Start () {

		// If the previous scene is faded out, create the black background
		if (PlayerPrefs.GetString ("faded out") == "true" && PlayerPrefs.GetString ("scene fade") == "false")
			Instantiate (sceneFade, gameObject.transform.position, gameObject.transform.rotation);
	}

	public void LoadLevel(string name) {
		// Swap values every time LoadLevel is called
		Instantiate (sceneFade, gameObject.transform.position, gameObject.transform.rotation);
		PlayerPrefs.SetString ("LoadLevel", name);
	}

	public void SplashButtonClicked(string cond) {
		PlayerPrefs.SetString ("splash button clicked", cond);
	}

	public void ReCalibrate() {
		PlayerPrefs.SetFloat ("reorient x", Input.acceleration.x);
		PlayerPrefs.SetFloat ("reorient y", Input.acceleration.y);
	}

	public void UnPauseGame() {
		Time.timeScale = 1f;
	}

	// Calibrate device acceleration input
/*	public void Calibrate() {
		
		Vector3 accel = Input.acceleration;
		Quaternion rotateQuaternion = Quaternion.FromToRotation(new Vector3(0f, 0f, -1f), accel);

		//create identity matrix ... rotate our matrix to match up with down vec
		Matrix4x4 matrix = Matrix4x4.TRS(Vector3.zero, rotateQuaternion, new Vector3(1f, 1f, 1f));
		//get the inverse of the matrix
		this.calibrationMatrix = matrix.inverse;
	}

	//Whenever you need an accelerator value from the user
	//call this function to get the 'calibrated' value
	Vector3 getAccelerometer(Vector3 accelerator){
		Vector3 accel = this.calibrationMatrix.MultiplyVector(accelerator);
		return accel;
	}*/

	// Update is called once per frame
	void Update () {
		
	}
}