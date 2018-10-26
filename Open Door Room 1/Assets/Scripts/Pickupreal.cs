using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupreal : MonoBehaviour {

	public int distanceToItem;
	public GameObject inventorypanel;
	public GameObject[] inventoryicons;


	void Update(){


	Collect();

	}

	void Collect(){

		if (Input.GetMouseButtonUp (0)) {

		RaycastHit hit;

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);



		if (Physics.Raycast (ray, out hit, distanceToItem)) {
		GameObject i;
		if (hit.collider.gameObject.tag == "item" && hit.collider.gameObject.name == "Book") {
		i = Instantiate (inventoryicons [4]);
		i.transform.SetParent (inventorypanel.transform);
		Destroy (hit.collider.gameObject);
		} else if (hit.collider.gameObject.tag == "item" && hit.collider.gameObject.name == "BathroomKey") {
		i = Instantiate (inventoryicons [0]);
		i.transform.SetParent (inventorypanel.transform);
		Destroy (hit.collider.gameObject);
		} else if (hit.collider.gameObject.tag == "item" && hit.collider.gameObject.name == "BedroomKey") {
		i = Instantiate (inventoryicons [1]);
		i.transform.SetParent (inventorypanel.transform);
		Destroy (hit.collider.gameObject);
		} else if (hit.collider.gameObject.tag == "item" && hit.collider.gameObject.name == "KitchenKey") {
		i = Instantiate (inventoryicons [2]);
		i.transform.SetParent (inventorypanel.transform);
		Destroy (hit.collider.gameObject);
		} else if (hit.collider.gameObject.tag == "item" && hit.collider.gameObject.name == "Libary") {
		i = Instantiate (inventoryicons [3]);
		i.transform.SetParent (inventorypanel.transform);
		Destroy (hit.collider.gameObject);
		}
		}
		

		}
	}
}