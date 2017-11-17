using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextColor : MonoBehaviour {

	static private Color[] colors = { 
		Color.white, 
		Color.green, 
		Color.red,
		Color.gray
	};

	private GameObject colorPicker;
	private SpriteRenderer sr;
	[HideInInspector]
	public Color color;

	void Awake(){
		colorPicker = gameObject.transform.GetChild(0).gameObject;
		sr = colorPicker.GetComponent<SpriteRenderer>();
		randColor();
	}

	public void randColor(){
		int random = Random.Range(0, colors.Length);
		setColor(colors[random]);
	}

	public void setColor(Color newColor){
		color = newColor;
		sr.color = newColor;
	}
}
