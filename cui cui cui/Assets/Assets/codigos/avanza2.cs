using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avanza2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0,globalvariables.velocidad);
		if(globalvariables.velocidad>0.2f){
			globalvariables.velocidad-=0.00005f;
		}
		if(globalvariables.gameOn==true&&globalvariables.velocidad<0.2f){
			globalvariables.velocidad+=0.001f;
		}
		
	}
}
