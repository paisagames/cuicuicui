using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corrigecorazon : MonoBehaviour {

	public Transform avion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(avion.position.z<transform.position.z){
				transform.position=new Vector3(Random.Range(avion.position.x-0.4f,avion.position.x+0.4f),avion.position.y,avion.position.z-1000f);


		}
	}
}
