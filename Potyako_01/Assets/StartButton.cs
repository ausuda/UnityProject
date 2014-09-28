using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	//private GUIStyle style;
	// Use this for initialization
	void Start () {
	//	style = new GUIStyle ();
	//	style.fontSize = 30;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		Rect rect = new Rect(Screen.width * 2/10, Screen.height * 8 / 10, Screen.width * 2/3, Screen.height /10);
		bool isClicked = GUI.Button(rect, "Set UP!!");
		if (isClicked)
		{
			Application.LoadLevel("test_first");
		}
	}
}
