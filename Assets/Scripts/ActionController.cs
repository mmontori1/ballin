using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour {

	private NextColor nextColor;
	private BallGenerator generator;
	private float speed;
	private bool input;

	private Action space;

	void Start () {
		speed = 10f;
		generator = GetComponent<BallGenerator>();
		nextColor = GetComponent<NextColor>();

		space = new Action(KeyCode.Space);
		space.action = forward;
	}
	
	void Update () {
		setAction();
		space.Perform();
	}

	void setAction(){
		bool isWhite = (nextColor.color == Color.white);
		if(isWhite){
			space.action = mirror;
		}
		else {
			space.action = forward;
		}
	}				

	void shoot(int direction){
		GameObject newBall = generator.generate ();

		Ball ball = newBall.GetComponent<Ball> ();
		ball.setColor (nextColor.color);
		nextColor.randColor ();

		Rigidbody2D rb = newBall.GetComponent<Rigidbody2D> ();
		rb.velocity = transform.up * speed * direction;
	}

	void forward(){
		shoot(1);
	}

	void mirror(){
		shoot(1);
		shoot(-1);
	}


}
