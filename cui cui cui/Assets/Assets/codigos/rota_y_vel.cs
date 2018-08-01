using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rota_y_vel : MonoBehaviour {
	public float y;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,y,0);
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="Enemy"||other.tag=="bola"){
			float zother=other.transform.position.z;
			zother+=500f;
			other.transform.position=new Vector3(other.transform.position.x,other.transform.position.y,zother);
		}
	}
}
