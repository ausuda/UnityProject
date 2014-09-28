using UnityEngine;
using System.Collections;

public class StartCount : MonoBehaviour {

	float time = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;
		if (time > 2.0) {
						Application.LoadLevel ("test_02");
				}
	}
}
