using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : MonoBehaviour {

	public float speed;
	private bool switcher;

	void Start(){
		switcher = false;
		speed = 3.5f;
		InputSystem.input.horizontal = rotation;
		InputSystem.input.s = switchAction;
	}

	void rotation(float input){
		speed = 3.5f;
		transform.Rotate (Vector3.forward * -input * speed);
	}

	void translation(float input){
		speed = 0.1f;
		var move = new Vector3(input, 0, 0);
		transform.position += move * speed;
	}

	void switchAction(){
		if (switcher) {
			InputSystem.input.horizontal = rotation;
		} 
		else {
			InputSystem.input.horizontal = translation;
		}
		switcher = !switcher;
	}
}
