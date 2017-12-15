using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {
	public GameObject thekey;
	private bool playernexttokey = false;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0) && playernexttokey == true) {
		thekey.active = false;

		}
		
	}
	void OnTriggerEnter (Collider thecollider){
		if (thecollider.tag == "Player") {
		playernexttokey = true;

		}

	}
	void OnTriggerExit (Collider thecollider){
		if (thecollider.tag == "Player") {
		playernexttokey = false;

		}

	}
}
