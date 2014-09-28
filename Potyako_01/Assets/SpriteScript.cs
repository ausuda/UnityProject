using UnityEngine;
using System.Collections;

public class SpriteScript : MonoBehaviour {
	
	SpriteRenderer renderer;
	public Sprite[] image;
	int idx;
	void Start () {
		renderer = GetComponent<SpriteRenderer>();
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			renderer.sprite = image[idx];
			idx++;
			if (idx >= image.Length) idx = 0;
		}
	}
}
