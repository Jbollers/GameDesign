using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiTrans : MonoBehaviour {

    public Transform player;
    private NavMeshAgent myagent;
    Animator anim;
    public Transform head;
    bool pursuing = false;
  //  public GameObject enemy;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        myagent = GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        
        Vector3 direction = player.position - this.transform.position;
        direction.y = 0;
        float angle = Vector3.Angle(direction, head.up);
		if(Vector3.Distance(player.position, this.transform.position) < 10 && angle < 60 || pursuing)
        {

            pursuing = true;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIdle", false);
            if(direction.magnitude > 5)
            {
                //this.transform.Translate(0, 0, 0.05f);
                myagent.SetDestination(player.position);
                anim.SetBool("isWalking", true);
                anim.SetBool("isAttacking", false);
            }
            else
            {
                anim.SetBool("isAttacking", true);
                anim.SetBool("isWalking", false);
            }
        }
        else
        {
            pursuing = false;
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
        }
	}

}
