using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Fires shots
/// </summary>
public class Mover : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {

		// Local positive z axis -> transform.forward
		this.GetComponent<Rigidbody> ().velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
