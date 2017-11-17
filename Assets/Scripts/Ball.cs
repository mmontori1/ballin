using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	[HideInInspector]
	public Color color;
	private SpriteRenderer sr;

	void Awake(){
		sr = GetComponent<SpriteRenderer>();
	}

	void OnBecameInvisible(){
		Destroy(gameObject);
	}

	public void setColor(Color newColor){
		color = newColor;
		sr.color = newColor;
	}
}
