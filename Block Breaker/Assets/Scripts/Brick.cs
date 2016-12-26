using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;

	// Use this for initialization
	void Start () {
		timesHit = 0;
	}

	void OnCollisionEnter2D(Collision2D collision) {
		timesHit++;
	}
	
	// Update is called once per frame
	void Update () {
		if (timesHit == maxHits) {
			Destroy (gameObject);
		}
	}
}
