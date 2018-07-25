using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class avanza3 : MonoBehaviour {

public Image imageshoot;


//hay un pedo para quitar el circulo de vida y velocidad la primera vez que se juega
		public SpriteRenderer firerender;

		double tiempofirerender;
	public AudioSource sonidostrella;
	public Text texto;
	int privado;

	// Use this for initialization
	void Start () {
		tiempofirerender=1500;
		privado=0;
	}
	
	// Update is called once per frame
	void Update () {
		texto.text=""+globalvariables.puntos;

		

			tiempofirerender=tiempofirerender+Time.time;
			if(tiempofirerender<1000){firerender.enabled=true;
			}else{firerender.enabled=false;}
			nivel2.revisalevel=false;
		
		
	}
	void guardaestrellas(){

		if(PlayerPrefs.HasKey("totalstars")){
			int totalstarsint=PlayerPrefs.GetInt("totalstars");
			totalstarsint+=globalvariables.puntos;
			PlayerPrefs.SetInt("totalstars",totalstarsint);

		}else{
			int totalstarsint=globalvariables.puntos;
			PlayerPrefs.SetInt("totalstars",totalstarsint);
		}
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

		tiempofirerender=0;

		if(imageshoot.enabled==true){
			imageshoot.enabled=false;
		}
		nivel2.revisalevel=true;
		

	}		


	guardaestrellas();	
	}
	
}
