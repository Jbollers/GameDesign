using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	Vector2 mouselook;
	Vector2 smoothv;
	public float sensitivity =5.0f;
	public float smoothing = 2.0f;

	GameObject character;

	// Use this for initialization
	void Start () {
		character = this.transform.parent.gameObject;
		
	}
	
	// Update is called once per frame
	void Update () {

	var md = new Vector2(Input.GetAxisRaw("Mouse X"),Input.GetAxisRaw("Mouse Y"));

		md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
		smoothv.x=Mathf.Lerp(smoothv.x, md.x, 1f / smoothing);
		smoothv.y=Mathf.Lerp(smoothv.y, md.y, 1f / smoothing);
		mouselook+=smoothv;

		transform.localRotation=Quaternion.AngleAxis(-mouselook.y, Vector3.right);
		character.transform.localRotation=Quaternion.AngleAxis(mouselook.x, character.transform.up);
		
	}
}
