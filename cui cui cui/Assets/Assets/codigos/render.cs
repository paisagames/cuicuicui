using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class render : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="render"){
		Renderer render =transform.GetComponent<Renderer>();

		render.enabled=true;
		}

	}
	void OnTriggerStay(Collider other){
		Renderer render =transform.GetComponent<Renderer>();
		if(other.tag=="render"){
		

		render.enabled=true;
		}else{render.enabled=false;}

	}
}
