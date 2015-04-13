using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour
{
	// Use this for initialization
	public Text guessText;
	int max;
	int min;
	int guess;

	void Start ()
	{
		StartGame ();
	}

	void StartGame ()
	{
		max = 1000;
		min = 1;
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, down = lower, return = equal");
		guessText.text = guess.ToString ();
		NextGuess ();
	}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GuessHigher ();

		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GuessLower ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			GuessCorrect ();
		}
	}

	public void GuessHigher ()
	{
		min = guess;
		NextGuess ();
	}

	public void GuessLower ()
	{
		max = guess;
		NextGuess ();
	}

	public void GuessCorrect ()
	{
		print ("I won!");
		StartGame ();

	}

	void NextGuess ()
	{
		guess = (max + min) / 2;
		guess = Random.Range (min, max + 1);
		print ("Higher or lower than " + guess);
		print ("Up = higher, down = lower, return = equal");
		guessText.text = guess.ToString ();
	}
}