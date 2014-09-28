using UnityEngine;
using System.Collections;

public class FirstText : MonoBehaviour {

	string text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
	string text2 = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb";
	string text3 = "cccccccccccccccccccccccccccccccccccccccccc";

	string d = "";
	private float time = 0;
	private float time2 = 0;
	private int len = 0;
	private int no = 0;

	public GUIStyle style;
	// Use this for initialization
	void Start () {
	
		//style = new GUIStyle ();
		//style.fontSize = 20;

	}
	
	// Update is called once per frame
	void Update () {
		//Touch touch = Input.GetTouch (0);
		//bool touchPhase = (touch.phase == TouchPhase.Began);
		time += Time.deltaTime;
		if (time > 0.05)
		{
			if(no == 0 && text.Length > len)
				d += text.Substring (len, 1);
			else if(no == 1 && text2.Length > len)
				d += text2.Substring(len, 1);
			else if(no == 2 && text3.Length > len)
				d += text3.Substring(len, 1);


			time2 += Time.deltaTime;
			if(no == 2 && text3.Length == len && time2 > 0.5){
				Application.LoadLevel("get_manpokei");
			}
			if(text.Length > len || text2.Length > len || text3.Length > len)
				len++;

			time = 0;
		}

		if(((no == 0 && text.Length <= len) || (no == 1 && text2.Length <= len))){
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Began){
				d = "";
				len = 0;
				no++;
			}
			
		}
	}

	void OnGUI()
	{
		Rect rect1 = new Rect(Screen.width / 30, Screen.height * 2/ 3, Screen.width * 28 / 30, Screen.height  / 3);

		GUI.Box(rect1, d,style);
	}
}
