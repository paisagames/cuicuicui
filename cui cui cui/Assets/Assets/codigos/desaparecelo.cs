using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desaparecelo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){

		
		Renderer render=other.GetComponent<Renderer>();
		render.enabled=false;

		MeshRenderer meshrender=other.GetComponent<MeshRenderer>();
		meshrender.enabled=false;
		

	}
}
