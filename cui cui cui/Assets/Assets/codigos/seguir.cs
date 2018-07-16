using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seguir : MonoBehaviour {

	bool boleano;
	public Text textimpo;
	double tiempo;
	float velocidadseg;
	float x;
	public Transform star;
	public Transform star2;
	public Transform star3;
	public Transform star4;
	double vv;
	// Use this for initialization
	void Start () {
		vv=0;
		boleano=false;
		tiempo=0;
		x=2f;
		velocidadseg=0.03f;
	}
	
	// Update is called once per frame
	void Update () {
		tiempo =tiempo+ Time.time;
		if(tiempo>10000){tiempo=0;}
		
		if(vv<1000){
			transform.LookAt(star);
		}else{
				if(vv<3000){transform.LookAt(star2);}else{
						if(vv<7000){transform.LookAt(star3);}else{transform.LookAt(star4);}
				}

		}
		transform.Translate(0,0,2f);
	}
}
