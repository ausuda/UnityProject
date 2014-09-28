using UnityEngine;
using System.Collections;

public class Walker : MonoBehaviour {

	static int walkCount;
	private static bool scene11Flag = true;
	private float prePosX = 0;
	private float prePosY = 0;
	private float prePosZ = 0;
	private float posX = 0;
	private float posY = 0;
	private float posZ = 0;
	float time = 0;


	SpriteRenderer sprender;

	//public Sprite NormalPocha;
	//public Sprite MidPocha;
	//static Component sprite;
	static GameObject NormalPocha;
	static GameObject MidPocha;

	private GUIStyle style;
	// Use this for initialization
	void Start () {
		style = new GUIStyle();
		style.fontSize = 30;
		style.normal.textColor = Color.black;
		sprender = gameObject.GetComponent<SpriteRenderer> ();
		NormalPocha = GameObject.Find ("ぽちゃやせ_0");
		MidPocha = GameObject.Find ("ポチャ子中_0");
		NormalPocha.SetActive (true);
		MidPocha.SetActive (false);
		if (walkCount > 10) {
			NormalPocha.SetActive (false);
			MidPocha.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 0.1) {
						posX = Input.acceleration.x;
						posY = Input.acceleration.y;
						posZ = Input.acceleration.z;
			//posX += 0.1f;
			//posY += 0.1f;
			//posZ += 0.1f;

						float prevec = prePosX * prePosX + prePosY * prePosY + prePosZ * prePosZ;
						float vec = posX + posX + posY * posY + posZ * posZ;

						if (System.Math.Abs (prevec - vec) > 2.0) {
								walkCount++;
				prePosX = posX;
				prePosY = posY;
				prePosZ = posZ;
						}
			time = 0;
				}

	}

	void OnGUI(){
				string w = walkCount.ToString();
				GUI.Label (new Rect (0, 0, 120, 50), w, style);

		if (walkCount > 10 && scene11Flag) {
						Application.LoadLevel ("Scene1-1");
			scene11Flag = false;

				}
		}

//	void ChangeToMid(){
//				sprender.sprite = MidPocha;
//		}
}
