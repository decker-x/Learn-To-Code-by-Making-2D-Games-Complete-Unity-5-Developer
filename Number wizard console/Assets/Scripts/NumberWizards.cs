		using UnityEngine;
		using System.Collections;

		public class NumberWizards : MonoBehaviour {

			// Use this for initialization
			void Start () {
				print ("Welcome to Number Wizard!");
				print ("Pic a number in your head but don't tell me!");
			
				int max = 1000;
				int min = 1;

				print ("the highest number you can pick is" + max);
				print ("the lowest number you can pick is" + min);

				print ("is the number higher or lower than 500?" );
				print ("Up = Higher, down = lower, return = equal");
			}
			
			// Update is called once per frame
			void Update () {
					if (Input.GetKeyDown (KeyCode.UpArrow)) {
							print ("Up arrow pressed");
					}
					if (Input.GetKeyDown (KeyCode.DownArrow)) {
							print ("Down arrow pressed");
					}
			}

		}
