using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disparaCorrected : MonoBehaviour {

double tiempo;
	public static bool activadisparo;
	//public Transform nave;
	public Rigidbody projectil;
	public Transform puntodelanzamiento;
	float v = 90f;
	void Start () {
		v=90f;	
		tiempo=0;
		activadisparo=false;
	}

	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.time;
		//transform.LookAt(nave);
		
		if (Input.GetKeyDown (KeyCode.V)) {
			v += 10f;}
		if (Input.GetKeyDown (KeyCode.B)) {
			v -= 10f;}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Rigidbody instantiatedProjectile = Instantiate (projectil, puntodelanzamiento.position, projectil.rotation) as Rigidbody;

			instantiatedProjectile.velocity=transform.TransformDirection(new Vector3(0,0,globalvariables.velocidad*2));
			
		}	
		if(activadisparo==true){
			if(tiempo>100){
			Rigidbody instantiatedProjectile = Instantiate (projectil, puntodelanzamiento.position, projectil.rotation) as Rigidbody;

			instantiatedProjectile.velocity=transform.TransformDirection(new Vector3(0,0,globalvariables.velocidad*2));
			}
			if(tiempo>730){tiempo=0;}
		}

}




void OnTriggerEnter(Collider other){
/*	if(other.tag=="Player")
	{	transform.LookAt(nave);
			Rigidbody instantiatedProjectile = Instantiate (projectil, puntodelanzamiento.position, transform.rotation) as Rigidbody;

			instantiatedProjectile.velocity=transform.TransformDirection(new Vector3(0,0,v));
	}
}
void OnTriggerStay(Collider other){
	if(other.tag=="Player")
	{	transform.LookAt(nave);
			Rigidbody instantiatedProjectile = Instantiate (projectil, puntodelanzamiento.position, transform.rotation) as Rigidbody;

			instantiatedProjectile.velocity=transform.TransformDirection(new Vector3(0,0,v));
	}*/
}

}