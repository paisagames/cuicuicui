using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mueveydispara : MonoBehaviour {
	
	public Image pizza1;
	public Image pizza2;
	public Image pizza3;
	public Image pizza4;
	public Image pizza5;
	public Image pizza6;
	public Image pizza7;
	public Image pizza8;
	//----------------------

	
	public Text textoprueba;
	
	
	public AudioSource laser;
	bool derechabol;
	bool izquierdabool;
	
	bool subebalas;

	public static bool activadisparo;
	//public Transform nave;
	public Rigidbody projectil;
	public Transform puntodelanzamiento;
	public Transform puntodelanzamiento2;
	public Transform puntodelanzamiento3;

	
	double totalmovido;
	double tiempo;
	int limitedebalas;
	// Use this for initialization
	void Start () {








		limitedebalas=30;
		globalvariables.puededisparar=true;
		tiempo=0;
		subebalas=false;
		derechabol=false;
		izquierdabool=false;
		totalmovido=0;

		if(PlayerPrefs.HasKey("maxbalas")){
			limitedebalas=PlayerPrefs.GetInt("maxbalas");

		}else{
			limitedebalas=30;
			PlayerPrefs.SetInt("maxbalas",30);
		}
		globalvariables.nbalas=limitedebalas;


		
	}
	
	// Update is called once per frame
	void Update () {

		
			if(globalvariables.nbalas>(limitedebalas*.80)){pizza8.enabled=true;}else{pizza8.enabled=false;}
			if(globalvariables.nbalas>(limitedebalas*.70)){pizza7.enabled=true;}else{pizza7.enabled=false;}
			if(globalvariables.nbalas>(limitedebalas*.60)){pizza6.enabled=true;}else{pizza6.enabled=false;}
			if(globalvariables.nbalas>(limitedebalas*.50)){pizza5.enabled=true;}else{pizza5.enabled=false;}
			if(globalvariables.nbalas>(limitedebalas*.40)){pizza4.enabled=true;}else{pizza4.enabled=false;}
			if(globalvariables.nbalas>(limitedebalas*.25)){pizza3.enabled=true;}else{pizza3.enabled=false;}
			if(globalvariables.nbalas>(limitedebalas*.10)){pizza2.enabled=true;}else{pizza2.enabled=false;}
			if(globalvariables.nbalas>(limitedebalas*.01)){pizza1.enabled=true;}else{pizza1.enabled=false;}
			






		//tiempo=tiempo+Time.time;
		//	textoprueba.text=""+tiempo;


		

		if(subebalas==true){
	
		}
		

		

		if(derechabol==true){
			derecha();
		}
		if(izquierdabool==true){
			izquierda();
		}
		
	}

	public void cargabalas(){

		
			
			
			
			
			
			globalvariables.nbalas+=5;
			
			
			tiempo=0;
			globalvariables.puededisparar=true;
			if(globalvariables.nbalas>limitedebalas){globalvariables.nbalas=limitedebalas;}
			
			
			
			
		

	}
	public void izquierda(){
		if(totalmovido>-5){
		transform.Translate(-0.20f,0,0);
		
		totalmovido-=0.5;}
	
	}
	public void derecha(){
		if(totalmovido<5){
		transform.Translate(0.20f,0,0);
		
		totalmovido+=0.5;}
		
	}
	public void dispara(){
		//nbalas es float
	

		if(globalvariables.nbalas>0&&globalvariables.puededisparar==true){
		//arma1
			
			subebalas=false;
			globalvariables.nbalas--;
//		imagenbalas.rectTransform.sizeDelta=new Vector2(imagenbalas.rectTransform.sizeDelta.x,globalvariables.nbalas*25f);
			Rigidbody instantiatedProjectile = Instantiate (projectil, puntodelanzamiento.position, projectil.rotation) as Rigidbody;

			instantiatedProjectile.velocity=transform.TransformDirection(new Vector3(0,0,(globalvariables.velocidad*2f)+90f));
			
			if(globalvariables.sonidoactivadobool==true){
			laser.Play();}


		//arma2
		if(globalvariables.arma2activa==true){
		globalvariables.nbalas--;
		Rigidbody instantiatedProjectile2 = Instantiate (projectil, puntodelanzamiento2.position, projectil.rotation) as Rigidbody;

			instantiatedProjectile2.velocity=transform.TransformDirection(new Vector3(0,0,(globalvariables.velocidad*2f)+90f));
		}

		//arma3
		if(globalvariables.arma3activa==true){
		globalvariables.nbalas--;
		Rigidbody instantiatedProjectile3 = Instantiate (projectil, puntodelanzamiento3.position, projectil.rotation) as Rigidbody;

			instantiatedProjectile3.velocity=transform.TransformDirection(new Vector3(0,0,(globalvariables.velocidad*2f)+90f));
		}

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
