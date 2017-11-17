using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour {

	private BallGenerator generator;
	private float speed;
	private bool input;

	void Start () {
		speed = 10f;
		generator = GetComponent<BallGenerator>();
	}
	
	void Update () {
		input = Input.GetKeyDown(KeyCode.Space);
		if (input) {
			GameObject ball = generator.generate();
			Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
			rb.velocity = transform.up * speed;
		}
	}
}
