using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour {

	private Object ball;

	void Start(){
		ball = Resources.Load("Ball");
	}

	public GameObject generate(){
		GameObject newBall = Instantiate(ball, transform.position, Quaternion.identity) as GameObject;
		newBall.hideFlags = HideFlags.HideInHierarchy;
		return newBall;
	}

}
