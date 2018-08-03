using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshrenderbalaalien : MonoBehaviour {
public MeshRenderer mr1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="render"){
	
		mr1.enabled=true;
	
	
		}

	}
	void OnTriggerStay(Collider other){
		MeshRenderer render =transform.GetComponent<MeshRenderer>();
		if(other.tag=="render"){
		mr1.enabled=true;
	

		
		}else{
		mr1.enabled=false;
		}

	}
}
