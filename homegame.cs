using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	Vector2 location; //global var

	// Use this for initialization
	void Start () {
		Vector2 location = new Vector2(3.0f, 2.0f);
		Vector2 homeLocation = new Vector2(2.1f, 5.0f);
		Vector2 pathToHome = homeLocation - location;
		//bool isTwoGreaterThanOne = 2 > 1; // equals true
		print ("Welcome to GO Home!");
		Invoke ("TimedPrint", 2.0f);
		print ("Distance = " + pathToHome.magnitude);
	

		if (location > homeLocation) {
			print ("Go back to get home");
		}
		else if (homeLocation > location) {
			print ("Go forward to get home");
		}
		else {
			print ("I am at home");
		}
	
	}
			
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			location += Vector2.left;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			location += Vector2.right;
		}
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			location += Vector2.up;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			location += Vector2.down;
		}
	}
	void TimedPrint()
	{
		print ("game where you go home");
		//cancel invoke
	}
}