using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHomeGame : MonoBehaviour {

	public Vector2 playerLocation;
	public Vector2 homeLocation;
	bool gameOver = false;

	// Use this for initialization
	void Start () {
		print("Welcome to Go Home!");
	}

	// Update is called once per frame
	void Update () {
		if (!gameOver) {
			UpdateMovement (KeyCode.LeftArrow, new Vector2 (-1, 0));
			UpdateMovement (KeyCode.RightArrow, new Vector2 (1, 0));
			UpdateMovement (KeyCode.UpArrow, new Vector2 (0, 1));
			UpdateMovement (KeyCode.DownArrow, new Vector2 (0, -1));
		}
	}

	private void UpdateMovement(KeyCode kc, Vector2 movementVector)
	{
		if (Input.GetKeyDown (kc)) {
			playerLocation = playerLocation + movementVector;
			PrintDistanceToHome ();
		}
	}

	private void PrintDistanceToHome()
	{
		Vector2 pathToHome = homeLocation - playerLocation;
		print ("Distance to home: " + pathToHome.magnitude);
		if (playerLocation == homeLocation) 
		{
			gameOver = true;
			print ("Welcome Home!");
		}
	}

		
}
