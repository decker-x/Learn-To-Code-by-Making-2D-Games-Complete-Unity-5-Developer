using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instace = null;

	// Use this for initialization
	void Start () {
		if (instace != null) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!!");
		} else {
			instace = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
