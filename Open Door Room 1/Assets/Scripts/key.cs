using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {
	public GameObject thekey; //Reference to key
	private bool playernexttokey = false;
    public GameObject parasite; //Reference to enemy
    public GameObject person; //Reference to human host
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0) && playernexttokey == true) {
		thekey.SetActive(false);
            parasite.SetActive(true);
            person.SetActive(false);

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
