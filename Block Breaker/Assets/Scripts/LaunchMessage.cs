using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchMessage : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			Destroy (gameObject);
	}
}
