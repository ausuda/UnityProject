using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	public AudioClip a;
	public AudioClip b;

	int count=0;
	int flg=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		count++;


		if (count == 50) {
			FixedUpdate();
						//audio.Stop ();
						//audio.clip = b;
						//audio.Play ();
				}
		if (flg == 1) {
						audio.clip = b;
			audio.volume=1;
						audio.Play ();
						flg = 0;
				}
	
	}



	

		
		/*
	About
		Easy Fade In
		By Desi Quintans (CowfaceGames.com), 18 August 2012.
 
	License
		Free as in speech, and free as in beer.
 
	Usage
		Attach this script to a GameObject with an AudioSource and enter a fade time. Easy Fade In will
		smoothly increase the audiosource's volume over this period of time until it reaches maximum
		volume, and then will destroy itself to prevent wasting a FixedUpdate() check.
	*/
		
		public int approxSecondsToFade = 10;
		
		void FixedUpdate ()
		{
			if (audio.volume > 0)
			{
				audio.volume = audio.volume - (Time.deltaTime / (approxSecondsToFade + 1));
			}
			else
			{
			flg=1;
				//Destroy (this);
			}

	}
}
