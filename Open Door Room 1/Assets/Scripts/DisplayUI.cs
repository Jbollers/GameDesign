using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour {

	public string mystring;
	public Text mytext;
	public float fadetime;
	public bool displayinfo;

	// Use this for initialization
	void Start () {


		mytext.color = Color.clear;
	}
	
	// Update is called once per frame
	void Update () {

		FadeText ();

		/*if (Input.GetKeyDown (KeyCode.Escape)) {
		Screen.lockCursor = false;
		}
		*/
	}

	void OnMouseOver()
	{
		displayinfo = true;
	}

	void OnMouseExit()
	{
		displayinfo = false;
	}

	void FadeText()
	{

		if (displayinfo) {
		mytext.text = mystring;
	mytext.color = Color.Lerp (mytext.color, Color.white, fadetime * Time.deltaTime);
		}
	else
	{
		mytext.color = Color.Lerp (mytext.color, Color.clear, fadetime * Time.deltaTime);
	}
}
}
