using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayonClick : MonoBehaviour {
	public Animation anim;
	private bool obj = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown(KeyCode.Mouse1) && obj == true){
	anim = GetComponent<Animation>();
	anim.Play (anim.clip.name);


	}

	}
	void OnTriggerEnter(Collider thecollider){
	if (thecollider.tag == "Player") {
	obj = true;

	}

	}
	void OnTriggerExit(Collider thecollider){
	if (thecollider.tag == "Player") {
	obj = false;

	}
		

	}

}
