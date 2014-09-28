using UnityEngine;
using System.Collections;

public class TestText : MonoBehaviour {

	string text = "Sample Text Box aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
	string d = "";
	private float time = 0;
	private int len = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 0.05)
		{
			if (text.Length > len) {
				d += text.Substring (len, 1);
			}
			len++;
			time = 0;
		}

	}

	void OnGUI()
	{
		Rect rect1 = new Rect(Screen.width / 30, Screen.height * 2/ 3, Screen.width * 28 / 30, Screen.height  / 3);
		GUI.TextArea(rect1, d);
	}
}
