using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {
	
	//get access to prefab we made. public makes it accessable to unity editor
	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float velocity = 5.0f;
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			//get the balls ridgid body componenet
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.left * velocity;
		}
		else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			//get the balls ridgid body componenet
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.right * velocity;
		}
		else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			//get the balls ridgid body componenet
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.forward * velocity;
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			//get the balls ridgid body componenet
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.back * velocity;
		}
	}
}
