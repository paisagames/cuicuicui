using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mueveydispara : MonoBehaviour {

	public Transform palodeavion;	
	public Text textoprueba;
	
	public Image imagenbalas;
	public AudioSource laser;
	bool derechabol;
	bool izquierdabool;
	
	bool subebalas;

	public static bool activadisparo;
	//public Transform nave;
	public Rigidbody projectil;
	public Transform puntodelanzamiento;

	double totalmovido;
	double tiempo;
	// Use this for initialization
	void Start () {
		globalvariables.puededisparar=true;
		tiempo=0;
		subebalas=false;
		derechabol=false;
		izquierdabool=false;
		totalmovido=0;
		
	}
	
	// Update is called once per frame
	void Update () {

		

		//tiempo=tiempo+Time.time;
		//	textoprueba.text=""+tiempo;

		imagenbalas.rectTransform.sizeDelta=new Vector2(imagenbalas.rectTransform.sizeDelta.x,globalvariables.nbalas*25f);
		
		

		if(subebalas==true){
			//if(globalvariables.nbalas<30f){
		//	globalvariables.nbalas+=0.20f;
			//imagenbalas.rectTransform.sizeDelta=new Vector2(imagenbalas.rectTransform.sizeDelta.x,globalvariables.nbalas*25f);
		//}
			//else{subebalas=false;}
		}
		

		

		if(derechabol==true){
			derecha();
		}
		if(izquierdabool==true){
			izquierda();
		}
		
	}

	public void cargabalas(){

		
			
			
			
			
			
			globalvariables.nbalas+=5f;
			
			globalvariables.nbalas++;
			tiempo=0;
			globalvariables.puededisparar=true;
			if(globalvariables.nbalas>30f){globalvariables.nbalas=30f;}
			
			
		

	}
	public void izquierda(){
		if(totalmovido>-5){
		transform.Translate(-0.20f,0,0);
		palodeavion.transform.Rotate(0,2.7f,0);
		totalmovido-=0.5;}
	
	}
	public void derecha(){
		if(totalmovido<5){
		transform.Translate(0.20f,0,0);
		palodeavion.transform.Rotate(0,-2.7f,0);
		totalmovido+=0.5;}
		
	}
	public void dispara(){
		if(globalvariables.nbalas>0&&globalvariables.puededisparar==true){
			subebalas=false;
		globalvariables.nbalas--;
		imagenbalas.rectTransform.sizeDelta=new Vector2(imagenbalas.rectTransform.sizeDelta.x,globalvariables.nbalas*25f);
		Rigidbody instantiatedProjectile = Instantiate (projectil, puntodelanzamiento.position, projectil.rotation) as Rigidbody;

			instantiatedProjectile.velocity=transform.TransformDirection(new Vector3(0,0,(globalvariables.velocidad*2f)+90f));
			
			if(globalvariables.sonidoactivadobool==true){
			laser.Play();}


		}
	}


	public void derechadown(){
		derechabol=true;

	}
	public void derechaup(){

		derechabol=false;
	}

	public void izquierdadown(){
		izquierdabool=true;
	}
	public void izquierdaup(){
		izquierdabool=false;
	}
}
