using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{

	static MusicPlayer instace = null;

	void Awake ()
	{
		Debug.Log ("Music player awake" + GetInstanceID ());
		if (instace != null) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!!");
		} else {
			instace = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}

	}

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Music player awake" + GetInstanceID ());
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}
