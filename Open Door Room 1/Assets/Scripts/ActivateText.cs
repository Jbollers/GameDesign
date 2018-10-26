using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateText : MonoBehaviour {
//Add to collider to make a dialogue pop up
	public TextAsset thetext;
	public int startline;
	public int endline;
	public TextBoxManager thetextbox;
	public bool destroyonactivate;

	// Use this for initialization
	void Start () {
		thetextbox = FindObjectOfType<TextBoxManager> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.name == "player") {
		thetextbox.reloadscript (thetext);
		thetextbox.currentline = startline;
		thetextbox.endaline = endline;
		thetextbox.enabletextbox ();

		if (destroyonactivate) {
		Destroy (gameObject);
		}
		}
	}
}
