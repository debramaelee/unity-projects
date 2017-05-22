using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {
	public GameObject BallPrefab;
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 20.0f;
//		Vector3 cameraAngle = new Vector3(Camera.main.transform.eulerAngles.x, Camera.main.transform.eulerAngles.y, Camera.main.transform.eulerAngles.z);

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GameObject instance = Instantiate (BallPrefab);
			//get component that is type of Rigidbody
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.left * speed;
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GameObject instance = Instantiate (BallPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.right * speed;
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GameObject instance = Instantiate (BallPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.forward * speed;
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GameObject instance = Instantiate (BallPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.back * speed;
		} else if (Input.GetButtonDown("Fire1")) {
//			Camera camera = GetComponentInChildren<Camera> ();

			GameObject instance = Instantiate (BallPrefab);
			//x, y, z coor now equal to objects current pos "transform.pos" = camera's pos
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Camera.main.transform.rotation * Vector3.forward * speed;
//			rb.velocity = cameraAngle * speed;
//			print (cameraAngle);
		}

	}
}
