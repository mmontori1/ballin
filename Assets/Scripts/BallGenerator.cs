using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour {

	private GameObject ball;
	private Vector3 position;

	void Start(){
		ball = Resources.Load("Ball") as GameObject;
		position = new Vector3(transform.position.x, transform.position.y, ball.transform.position.z);
	}

	public GameObject generate(){
		GameObject newBall = Instantiate(ball, position, Quaternion.identity) as GameObject;
		newBall.hideFlags = HideFlags.HideInHierarchy;
		return newBall;
	}

}
