using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshrender : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="render"){
		MeshRenderer render =transform.GetComponent<MeshRenderer>();

		render.enabled=true;
		}

	}
	void OnTriggerStay(Collider other){
		MeshRenderer render =transform.GetComponent<MeshRenderer>();
		if(other.tag=="render"){
		

		render.enabled=true;
		}else{render.enabled=false;}

	}
}
