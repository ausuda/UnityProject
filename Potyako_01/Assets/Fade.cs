using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SpriteRenderer spRenderer = GetComponent<SpriteRenderer> ();
		Color c = spRenderer.color;
		c.a = 1;
		spRenderer.color = c;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
