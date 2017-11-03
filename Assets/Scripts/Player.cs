using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private GameObject player;

	void Start () {
		player = this.gameObject;
		player.AddComponent<InputSystem>();
		player.AddComponent<MovementSystem>();
	}
}
