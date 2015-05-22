using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	private bool hasStarted = false;
	// Use this for initialization
	void Start ()
	{
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		print (paddleToBallVector.y);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!hasStarted) {
			//Lock the ball relative to the paddle.
			this.transform.position = paddle.transform.position + paddleToBallVector;
			//Wait for a mouse press to launch.
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse clicked, launch ball");
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2 (2f, 10f);
			}
		}
	}

	void OnCollisionEnter2D (Collision2D collision){
		print ("Ball hit");
		Vector2 tweak = new Vector2 (Random.Range(0f,02f),Random.Range(0f,02f));
		if (hasStarted) {
			audio.Play ();
			rigidbody2D.velocity += tweak;
		}
	}
}
