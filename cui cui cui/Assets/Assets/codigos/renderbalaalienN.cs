using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renderbalaalienN : MonoBehaviour {
public Renderer r1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	
}
void OnTriggerEnter(Collider other){
		if(other.tag=="render"){
		
		r1.enabled=true;
		
		}

	}
	void OnTriggerStay(Collider other){
		
		if(other.tag=="render"){
		

		r1.enabled=true;
	
		}else{r1.enabled=false;
	}

	}
}
