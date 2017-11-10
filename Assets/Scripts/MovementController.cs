using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

	public float speed;
	private float input;

	void Start(){
		speed = 3.5f;
	}

	void Update(){
		input = Input.GetAxisRaw ("Horizontal");
		transform.Rotate (Vector3.forward * -input * speed);
	}
}
