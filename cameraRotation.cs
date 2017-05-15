using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float rotationSpeed = 3.0f;
		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;
		//need to change rotation to local to prevent tilting
		transform.localRotation = Quaternion.Euler (-mouseY, mouseX, 0) * transform.localRotation;
		Camera camera = GetComponentInChildren<Camera>;
		camera.transform.localRotation = Quaternion.Euler (-mouseY, 0, 0) * camera.transform.localRotation;
	}
}
