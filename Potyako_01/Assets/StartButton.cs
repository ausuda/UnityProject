using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		Rect rect = new Rect(Screen.width * 2/10, Screen.height * 8 / 10, Screen.width * 2/3, Screen.height /20);
		bool isClicked = GUI.Button(rect, "Set UP!!");
		if (isClicked)
		{
			Application.LoadLevel("test_02");
		}
	}
}
