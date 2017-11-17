using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour {

	private NextColor nextColor;
	private BallGenerator generator;
	private float speed;
	private bool input;

	void Start () {
		speed = 10f;
		generator = GetComponent<BallGenerator>();
		nextColor = GetComponent<NextColor>();
	}
	
	void Update () {
		input = Input.GetKeyDown(KeyCode.Space);
		if (input) {
			GameObject newBall = generator.generate();

			Ball ball = newBall.GetComponent<Ball>();
			ball.setColor(nextColor.color);
			nextColor.randColor();

			Rigidbody2D rb = newBall.GetComponent<Rigidbody2D>();
			rb.velocity = transform.up * speed;
		}
	}
}
