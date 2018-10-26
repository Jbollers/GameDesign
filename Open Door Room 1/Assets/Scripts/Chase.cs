using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour {
	private NavMeshAgent myagent;
	public Transform target;
	private Animator myanim;
    public bool chasetarget = true;
    public float stopdis = 2.5f;
    public float delay = 1.5f;
    private float attackcool;
    private float disfromtarg;

	// Use this for initialization
	void Start ()
	{
		myagent = GetComponent<NavMeshAgent>();
        myanim = GetComponent<Animator>();
        myagent.stoppingDistance = stopdis;
        attackcool = Time.time;

	}
	
	// Update is called once per frame
	void Update ()
	{
        ChaseTarget();
         
		
	}
    void ChaseTarget()
    {
        disfromtarg = Vector3.Distance(target.position, transform.position);
        if(disfromtarg >= stopdis)
        {
            chasetarget = true;
        }
        else
        {
            chasetarget = false;
            Attack();
        }
        if(chasetarget)
        {
            myagent.SetDestination(target.position);
            myanim.SetBool("isWalking", true);
        }
        else
        {
            myanim.SetBool("isWalking", false);
        }
    }
    void Attack()
    {
        if(Time.time > attackcool)
        {
            //myanim.SetBool("isAttcking", true);
            Debug.Log("Attack!");
            myanim.SetTrigger("Attack");
            attackcool = Time.time + delay;
        }
        
    }
}
