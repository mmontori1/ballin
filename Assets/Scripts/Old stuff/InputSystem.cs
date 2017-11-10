using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour{
	
	public delegate void Horizontal(float input);
	public delegate void Press();

	public Horizontal horizontal;
	public Press s;

	public static InputSystem input;

	void Awake () {
		input = this;
	}

	void Update () {
		HorizontalAction();
		SAction();
	}

	void HorizontalAction(){
		float input = Input.GetAxisRaw("Horizontal");
		horizontal(input);
	}

	void SAction(){
		if(Input.GetKeyDown(key: KeyCode.S)){
			s();
		}
	}
}
