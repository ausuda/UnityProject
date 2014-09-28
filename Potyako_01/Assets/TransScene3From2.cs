using UnityEngine;
using System.Collections;

public class TransScene3From2 : MonoBehaviour {

	private float time = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		time += Time.deltaTime;
		if (time > 3)
		{
			Application.LoadLevel("test_first_text");				
		}
	}
}
