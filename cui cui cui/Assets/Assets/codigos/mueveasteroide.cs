using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mueveasteroide : MonoBehaviour {
double tiempo;
bool direccion;
	// Use this for initialization
	void Start () {
		tiempo=Random.Range(1,3000);
		direccion=false;
		if(tiempo>2000){direccion=true;}
	}
	
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.time;

		if(direccion==false){if(transform.position.x>-12f)
		{transform.Translate(-0.3f,0,0);}}

		if(direccion==true){if(transform.position.x<25f){transform.Translate(0.3f,0,0);}}
		

		if(tiempo>2000){
			direccion=true;
			
		}
		if(tiempo>4000){tiempo=0;
		
		
		}
		if(tiempo<2000){direccion=false;}

	}
}
