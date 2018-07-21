using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class avanza3 : MonoBehaviour {
	public AudioSource sonidostrella;
	public Text texto;
	int privado;

	// Use this for initialization
	void Start () {
		privado=0;
	}
	
	// Update is called once per frame
	void Update () {
		texto.text=""+globalvariables.puntos;
		
	}
	void OnTriggerEnter(Collider other){
				if(other.tag=="star"){ 
			other.transform.position=new Vector3(Random.Range(transform.position.x-0.4f,transform.position.x+0.4f),Random.Range(0f,10f),transform.position.z-120f);
			globalvariables.puntos++;
			//privado++;
			//texto.text=""+globalvariables.newstars+"ff";
			

			if(globalvariables.velocidad<2.5f){
			globalvariables.velocidad=globalvariables.velocidad*1.25f; //.04f
			}
			
			
//			vel.text=""+(globalvariables.velocidad*1000)+"km/h" +"--"+ vida +"%";
			mueveydispara mueveydispara=new mueveydispara();
			mueveydispara.cargabalas();
			if(globalvariables.sonidoactivadobool==true){
			sonidostrella.Play();}

				
			if(globalvariables.puntos>PlayerPrefs.GetInt("max")){
				PlayerPrefs.SetInt("max",globalvariables.puntos);
			}	

	}			
	}
	
}
