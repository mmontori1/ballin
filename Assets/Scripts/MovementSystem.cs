using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : MonoBehaviour {
	
	public MovementComponent movement;
	private float input;

	void Start () {
		movement = new MovementComponent();
	}

	void Update () {
		input = Input.GetAxisRaw("Horizontal");
		transform.Rotate (Vector3.forward * -input * movement.speed);
	}
}
