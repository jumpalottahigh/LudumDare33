using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private float speed;
	private float rotSpeed;

	// Use this for initialization
	void Start () {

		speed = 10f;
		rotSpeed = 105f;
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetAxis ("Horizontal") > 0) {
			this.transform.Translate(Vector3.forward * Time.deltaTime);
		}*/

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.up, Time.deltaTime * -rotSpeed);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(Vector3.up, Time.deltaTime * rotSpeed);
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(Vector3.back * Time.deltaTime * speed);
		}

		if (Input.GetKey (KeyCode.Space)) {
			transform.Translate(Vector3.up * Time.deltaTime * speed * 2f);
		}
	
	}
}
