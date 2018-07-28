using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renderbalaalienN : MonoBehaviour {
public Renderer r1;
public Renderer r2;
public Renderer r3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	
}
void OnTriggerEnter(Collider other){
		if(other.tag=="render"){
		
		r1.enabled=true;
		r3.enabled=true;
		r2.enabled=true;
		}

	}
	void OnTriggerStay(Collider other){
		
		if(other.tag=="render"){
		

		r1.enabled=true;
		r2.enabled=true;
		r3.enabled=true;
		}else{r1.enabled=false;
		r2.enabled=false;
		r3.enabled=false;}

	}
}
