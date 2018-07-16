using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerebola : MonoBehaviour {
	public Transform nave;
	public AudioSource rocaexplota;
	public Transform cenizas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="bala"){
			cenizas.position=other.transform.position;
		transform.position=new Vector3(Random.Range(-2f,20f),Random.Range(0f,10f),nave.transform.position.z-200f);
			if(globalvariables.sonidoactivadobool==true){
			rocaexplota.Play();
			Renderer render=other.GetComponent<Renderer>();
			render.enabled=false;
			other.transform.position=new Vector3(0,1000f,0);
			}
			
}

	}
}
