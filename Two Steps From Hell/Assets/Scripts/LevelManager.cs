using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void LoadScene(string name) {
		SceneManager.LoadScene (name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
