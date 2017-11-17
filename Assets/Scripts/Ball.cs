using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	
	static private Color[] colors = { 
		Color.white, 
		Color.green, 
		Color.red,
		Color.gray
	};

	[HideInInspector]
	public Color color {
		get { return color; }
		set {
			sr.color = value;
		}
	}
	private SpriteRenderer sr;

	void Start(){
		sr = GetComponent<SpriteRenderer>();
		randColor();
	}

	void OnBecameInvisible(){
		Destroy(gameObject);
	}

	public void randColor(){
		int random = Random.Range(0, colors.Length);
		color = colors[random];
	}
}
