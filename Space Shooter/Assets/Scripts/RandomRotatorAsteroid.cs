using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotates asteroid when flying -> Sets angular velocity to a random Vector3 value
/// </summary>
public class RandomRotatorAsteroid : MonoBehaviour {

	// Max tumble value/rate
	public float tumble;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * tumble;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
