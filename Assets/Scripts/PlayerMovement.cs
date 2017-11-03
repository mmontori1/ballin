using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private float input;
	public float speed;

	void Start () {
		speed = 1;
	}

	void Update () {
		input = Input.GetAxisRaw("Horizontal");
		transform.Rotate (Vector3.forward * -input * speed);
	}
}
