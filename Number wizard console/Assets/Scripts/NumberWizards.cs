﻿using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour
{
	
	// Use this for initialization
	int max;
	int min;
	int guess;
	
	void Start ()
	{
		max = 1000;
		min = 1;
		guess = 500;
		
		max = max + 1;
		
		StartGame ();
	}
	
	void StartGame ()
	{
		
		print ("===========================");
		print ("Welcome to Number Wizard!");
		print ("Pic a number in your head but don't tell me!");
		
		
		print ("the highest number you can pick is" + max);
		print ("the lowest number you can pick is" + min);
		
		print ("is the number higher or lower than 500?");
		print ("Up = Higher, down = lower, return = equal");
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won");
			StartGame ();
		}
	}
	
	void NextGuess ()
	{
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("Up = Higher, down = lower, return = equal");
	}
	
}