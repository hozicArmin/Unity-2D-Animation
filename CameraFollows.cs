using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour {

	public Transform target;  //what the camera is following
	public float smoothing = 5f;

	Vector3 offset;


	// Use this for initialization
	void Start () {
		offset = transform.position - target.position;  //the difference between where the camera starts and where the player is
	}

	void FixedUpdate () {
		Vector3 targetCamPos = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);  //move the camera to a new position
	}
}
