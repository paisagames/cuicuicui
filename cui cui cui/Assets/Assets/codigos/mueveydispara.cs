using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mueveydispara : MonoBehaviour {
	
	public Image balaimag1;
	public Image balaimag2;
	public Image balaimag3;
	public Image balaimag4;
	public Image balaimag5;
	public Image balaimag6;
	public Image balaimag7;
	public Image balaimag8;
	public Image balaimag9;
	public Image balaimag10;
	public Image balaimag11;
	public Image balaimag12;
	public Image balaimag13;
	public Image balaimag14;
	public Image balaimag15;
	public Image balaimag16;
	public Image balaimag17;
	public Image balaimag18;
	public Image balaimag19;
	public Image balaimag20;
	public Image balaimag21;
	public Image balaimage22;
	public Image balaimag23;
	public Image balaimag24;
	public Image balaimag25;
	public Image balaimag26;
	public Image balaimag27;
	public Image balaimag28;
	public Image balaimag29;
	public Image balaimag30;
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

		
			if(globalvariables.nbalas>1){balaimag1.enabled=true;}else{balaimag1.enabled=false;}
			if(globalvariables.nbalas>2){balaimag2.enabled=true;}else{balaimag2.enabled=false;}
			if(globalvariables.nbalas>3){balaimag3.enabled=true;}else{balaimag3.enabled=false;}
			if(globalvariables.nbalas>4){balaimag4.enabled=true;}else{balaimag4.enabled=false;}
			if(globalvariables.nbalas>5){balaimag5.enabled=true;}else{balaimag5.enabled=false;}
			if(globalvariables.nbalas>6){balaimag6.enabled=true;}else{balaimag6.enabled=false;}
			if(globalvariables.nbalas>7){balaimag7.enabled=true;}else{balaimag7.enabled=false;}
			if(globalvariables.nbalas>8){balaimag8.enabled=true;}else{balaimag8.enabled=false;}
			if(globalvariables.nbalas>9){balaimag9.enabled=true;}else{balaimag9.enabled=false;}
			if(globalvariables.nbalas>10){balaimag10.enabled=true;}else{balaimag10.enabled=false;}
			if(globalvariables.nbalas>11){balaimag11.enabled=true;}else{balaimag11.enabled=false;}
			if(globalvariables.nbalas>12){balaimag12.enabled=true;}else{balaimag12.enabled=false;}
			if(globalvariables.nbalas>13){balaimag13.enabled=true;}else{balaimag13.enabled=false;}
			if(globalvariables.nbalas>14){balaimag14.enabled=true;}else{balaimag14.enabled=false;}
			if(globalvariables.nbalas>15){balaimag15.enabled=true;}else{balaimag15.enabled=false;}
			if(globalvariables.nbalas>16){balaimag16.enabled=true;}else{balaimag16.enabled=false;}
			if(globalvariables.nbalas>17){balaimag17.enabled=true;}else{balaimag17.enabled=false;}
			if(globalvariables.nbalas>18){balaimag18.enabled=true;}else{balaimag18.enabled=false;}
			if(globalvariables.nbalas>19){balaimag19.enabled=true;}else{balaimag19.enabled=false;}
			if(globalvariables.nbalas>20){balaimag20.enabled=true;}else{balaimag20.enabled=false;}
			if(globalvariables.nbalas>21){balaimag21.enabled=true;}else{balaimag21.enabled=false;}
			if(globalvariables.nbalas>22){balaimage22.enabled=true;}else{balaimage22.enabled=false;}
			if(globalvariables.nbalas>23){balaimag23.enabled=true;}else{balaimag23.enabled=false;}
			if(globalvariables.nbalas>24){balaimag24.enabled=true;}else{balaimag24.enabled=false;}
			if(globalvariables.nbalas>25){balaimag25.enabled=true;}else{balaimag25.enabled=false;}
			if(globalvariables.nbalas>26){balaimag26.enabled=true;}else{balaimag26.enabled=false;}
			if(globalvariables.nbalas>27){balaimag27.enabled=true;}else{balaimag27.enabled=false;}
			if(globalvariables.nbalas>28){balaimag28.enabled=true;}else{balaimag28.enabled=false;}
			if(globalvariables.nbalas>29){balaimag29.enabled=true;}else{balaimag29.enabled=false;}
			if(globalvariables.nbalas>30){balaimag30.enabled=true;}else{balaimag30.enabled=false;}






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

		
			
			
			
			
			
			globalvariables.nbalas+=5f;
			
			globalvariables.nbalas++;
			tiempo=0;
			globalvariables.puededisparar=true;
			if(globalvariables.nbalas>30f){globalvariables.nbalas=30f;}
			
			
		

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
			subebalas=false;
		globalvariables.nbalas--;
//		imagenbalas.rectTransform.sizeDelta=new Vector2(imagenbalas.rectTransform.sizeDelta.x,globalvariables.nbalas*25f);
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
