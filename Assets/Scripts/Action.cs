using UnityEngine;

public class Action {
	public Action(KeyCode newInput){
		input = newInput;
	}

	private KeyCode input;
	private bool press;

	public delegate void Act();
	public Act action;

	public void Perform(){
		press = Input.GetKeyDown(key: input);
		if (action != null && press) {
			action();
		}
	}
}