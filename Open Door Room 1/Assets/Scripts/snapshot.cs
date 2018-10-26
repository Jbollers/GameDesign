using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapshot : MonoBehaviour {

	// public variable to store the filename
	// so that you can choose the name in the inspector
	public string FileName = "whatever.png";
	
	void Update () {
		
		// if user presses the S key
		if(Input.GetKeyDown("f")) {

			// log it and capture the screen shot!
			Debug.Log ("screenshot captured!");

			ScreenCapture.CaptureScreenshot(FileName);
		}
	}
}
