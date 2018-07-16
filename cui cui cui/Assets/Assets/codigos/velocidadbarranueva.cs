using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class velocidadbarranueva : MonoBehaviour {

float dd;
	public Text texto;
	public Image barra;
	double sgundos;
	float tomavelocidad;
	float rotaciontotal;
	public Text rotaciontext;

	// Use this for initialization
	void Start () {
		rotaciontotal=0;
		sgundos=0;
		dd=0f;
		tomavelocidad=0;
	}
	
	// Update is called once per frame
	void Update () {
		sgundos=sgundos+Time.time;
		if(sgundos>500){
float x= barra.transform.rotation.z;
			if(tomavelocidad>globalvariables.velocidad){
				if(rotaciontotal>-150f){
				barra.transform.Rotate(0,0,-0.5f);
				
				rotaciontotal-=0.3f;
				rotaciontext.text=""+rotaciontotal+",v:"+globalvariables.velocidad+"z:"+x;
				}
			}else{if(tomavelocidad<globalvariables.velocidad){
				if(globalvariables.velocidad>0){
				barra.transform.Rotate(0,0,0.52f);
				
				rotaciontotal+=0.3f;
			
				rotaciontext.text=""+rotaciontotal+",v:"+globalvariables.velocidad+"z:"+x;
				}
				}
				
			}
			sgundos=0;
			tomavelocidad=globalvariables.velocidad;
		}

		texto.text="a:"+globalvariables.velocidad+",g:"+tomavelocidad;


	}
	
		
}