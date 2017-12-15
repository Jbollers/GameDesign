using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {
	public Animation doorclip;
	public GameObject key;
	private bool Door = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Mouse1) && Door == true && key.active == false){
	doorclip = GetComponent<Animation>();
		doorclip.Play (doorclip.clip.name);


	}

	}
	void OnTriggerEnter(Collider thecollider){
		if (thecollider.tag == "Player") {
		Door = true;

		}

	}
	void OnTriggerExit(Collider thecollider){
		if (thecollider.tag == "Player") {
		Door = false;

		}

	}
}
