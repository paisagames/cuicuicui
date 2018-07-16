using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altura : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y>8.67f){
			transform.Translate(0,-0.1f,0);
		}else{if(transform.position.y<8.67f){transform.Translate(0,0.1f,0);}}
	}
}
