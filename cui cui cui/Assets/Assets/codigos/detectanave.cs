﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectanave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider other){
		if(other.tag=="Player"){
			disparaCorrected.activadisparo=true;
		}
	}
}
