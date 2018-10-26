using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Trans : MonoBehaviour {

    public GameObject human;
    public GameObject enemy;
    //public GameObject target;
    public GameObject effect;
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetTrigger("Transforming");
            //effect.SetActive(true);
        }
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            anim.SetTrigger("Transforming");
            yield return new WaitForSeconds(3);
            human.SetActive(false);
            enemy.SetActive(true);
            //effect.SetActive(false);
            Debug.Log("Transforming!");
        }

    }

}
