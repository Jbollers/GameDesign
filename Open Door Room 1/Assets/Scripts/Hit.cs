using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Hit : MonoBehaviour {

	public Slider health;
	public GameObject gameovertext;
	public GameObject gameoverpanel;
	public GameObject restart;

	public FirstPersonController player;


	//public string damage;

	void OnTriggerEnter(Collider other)
	{

	if (other.gameObject.name == "RightArm") {
	health.value -= 20;
		} else {

		}

		
	//to do something when health reaches 0
		if (health.value <= 0) {
		gameoverpanel.SetActive (true);
		gameovertext.SetActive (true);
		restart.SetActive (true);
	player.canmove = false;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		}
	}

	// Use this for initialization
	void Start () {
		gameoverpanel.SetActive (false);
		gameovertext.SetActive (false);
		restart.SetActive (false);
	player = FindObjectOfType<FirstPersonController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
