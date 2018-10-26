using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnotherAi : MonoBehaviour {
	public Transform player;
	Animator anim;
	public Transform head;
    private NavMeshAgent myagent;

    string state = "patrol";
	public GameObject[] waypoints;
	int currentway=0;
	public float rotspeed=0.2f;
	public float speed=1.5f;
	float accuracyway=2.0f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
        myagent = GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = player.position - this.transform.position;
		direction.y = 0;
		float angle = Vector3.Angle(direction, head.up);

		if (state == "patrol" && waypoints.Length > 0) {
		anim.SetBool ("isIdle", false);
		anim.SetBool ("isWalking", true);
		if (Vector3.Distance (waypoints [currentway].transform.position, transform.position) < accuracyway) {
		//if you want random waypoints uncomment this line and comment the other ones in this statement
		//currentway = Random.Range (0, waypoints.Length);	
		currentway++;
		if (currentway >= waypoints.Length) {
		currentway = 0;
		}
		}
		
		direction = waypoints [currentway].transform.position - transform.position;
		this.transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (direction), rotspeed * Time.deltaTime);
		this.transform.Translate (0, 0, Time.deltaTime * speed);
	}
	if (Vector3.Distance (player.position, this.transform.position) < 10 && (angle < 60 || state =="pursuing")) {
		state = "pursuing";
		this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), rotspeed * Time.deltaTime);

		if (direction.magnitude > 1) {
                myagent.SetDestination(player.position);
               // this.transform.Translate (0, 0,Time.deltaTime * speed);
		anim.SetBool ("isWalking", true); 
		anim.SetBool ("isAttacking", false);
		}
	else {
		anim.SetBool ("isAttacking", true);
		anim.SetBool ("isWalking", false);

	}
		}
	else {
		anim.SetBool("isWalking", true);
		anim.SetBool("isAttacking", false);
		state = "patrol";

	}
	}
}
