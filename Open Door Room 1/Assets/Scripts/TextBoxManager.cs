using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class TextBoxManager : MonoBehaviour {
//If you want the text to pop up in the begining select isactive
//If you want the text to popup after a collision deselect is active and make sure to put
//the ActivateText script on collider
	public GameObject textbox;

	public Text thetext;

	public TextAsset textfile;
	public string[] textLines;

	public int currentline;
	public int endaline;

	public FirstPersonController player;

	public bool isactive;

	public bool stopplayer;

	// Use this for initialization
	void Start () {
	player = FindObjectOfType<FirstPersonController> ();

		if (textfile != null) {
		textLines = (textfile.text.Split ('\n'));
		}
		if (endaline == 0) {
		endaline = textLines.Length - 1;
		}
		if (isactive) {
		enabletextbox ();
		}
	else 
	{
		disabletextbox ();
		}
	}

	// Update is called once per frame
	void Update () {

		if (!isactive) {
		return;
		}

		thetext.text = textLines [currentline];
	if (Input.GetKeyDown(KeyCode.Return)) 
	{
		currentline += 1;
		}
		if (currentline > endaline) {
		disabletextbox ();
		}
	}
	public void enabletextbox()
	{
	textbox.SetActive (true);
		isactive = true;
		if (stopplayer) 
		{
		player.canmove = false;
		}
	}
	public void disabletextbox()
	{
	textbox.SetActive (false);
		isactive = false;
		player.canmove = true;
	}
	public void reloadscript(TextAsset thetext)
	{
		if (thetext != null) {
		textLines = new string[1];
	textLines = (thetext.text.Split ('\n'));
		}
	}
}