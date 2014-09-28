using UnityEngine;
using System.Collections;

public class Scene2_2 : MonoBehaviour {

	string text = " これでもっと早く痩せれるわ。";
	string text2 = " え？なんでそんなに痩せたいのかって？";
	string text3 = " アイドル目指してんのよ！悪い！？";
	string text4 = " いいから付き合いなさいよね！";
	
	string d = "";
	private float time = 0;
	private float time2 = 0;
	private int len = 0;
	private int no = 0;
	
	public GUIStyle style;
	// Use this for initialization
	void Start () {
		
		//style = new GUIStyle ();
		//sstyle.fontSize = 20;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		time += Time.deltaTime;
		if (time > 0.05)
		{
			if(no == 0 && text.Length > len)
				d += text.Substring (len, 1);
			else if(no == 1 && text2.Length > len)
				d += text2.Substring(len, 1);
			else if(no == 2 && text3.Length > len)
				d += text3.Substring(len, 1);
			else if(no == 3 && text4.Length > len)
				d += text4.Substring(len, 1);
			
			if(((no == 0 && text.Length == len) || (no == 1 && text2.Length == len)|| (no == 2 && text3.Length == len))){
				
				d = "";
				len = 0;
				no++;
				
			}
			time2 += Time.deltaTime;
			if(no == 3 && text4.Length == len && time2 > 0.5){
				Application.LoadLevel("test_02");
			}
			
			len++;
			time = 0;
		}
	}
	
	void OnGUI()
	{
		Rect rect1 = new Rect(Screen.width / 30, Screen.height * 2/ 3, Screen.width * 28 / 30, Screen.height  / 3);
		
		GUI.Box(rect1, d,style);
	}
}
