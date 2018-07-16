using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movealien : MonoBehaviour {
	public Transform cubovida;
	public Transform nave;
	int vidaalien;
	double tiempo;
	float totalmovido;
	int movimiento=1;
	// Use this for initialization
	void Start () {
		vidaalien=10;
		tiempo=0;
		movimiento=1;
		totalmovido=0;
	}
	
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.time;


		if(tiempo>3000){
			movimiento=Random.Range(1,4);
			tiempo=0;

		}
		switch(movimiento){
			case 1:if(totalmovido<3f){transform.Translate(0.02f,0,0);totalmovido+=0.02f;};break;
			case 2:if(totalmovido>-3){transform.Translate(-0.02f,0,0);totalmovido-=0.02f;}break;
			//case 3:if(totalmovido<2f){transform.Translate(0.04f,0,0);totalmovido+=0.02f;};break;
			//case 4:if(totalmovido>-2){transform.Translate(-0.02f,0,0);totalmovido-=0.02f;}break;


		}
		
	}

	
}
