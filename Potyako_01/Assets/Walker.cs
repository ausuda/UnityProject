using UnityEngine;
using System.Collections;

public class Walker : MonoBehaviour {

	private int walkCount = 0;
	private float prePosX = 0;
	private float prePosY = 0;
	private float prePosZ = 0;
	private float posX = 0;
	private float posY = 0;
	private float posZ = 0;
	float time = 0;

	private GUIStyle style;
	// Use this for initialization
	void Start () {
		style = new GUIStyle();
		style.fontSize = 30;
		style.normal.textColor = Color.black;
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
		}
}
