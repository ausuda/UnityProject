using UnityEngine;
using System.Collections;

public class Scene2_4 : MonoBehaviour {

	string text = " なかなか痩せないわね。";
	string text2 = " そんなときはこれ、我が家に伝わるダイエット秘伝の書。";

	
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

			
			if(((no == 0 && text.Length == len) )){
				
				d = "";
				len = 0;
				no++;
				
			}
			time2 += Time.deltaTime;
			if(no == 1 && text2.Length == len && time2 > 0.5){
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
