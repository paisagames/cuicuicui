using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class avanza3 : MonoBehaviour {

public Image imageshoot;
int limitedebalas;
int valormeteoro;
double resistenciaEscudo;



//hay un pedo para quitar el circulo de vida y velocidad la primera vez que se juega

	public SpriteRenderer renderObjetoEscudo;
	public BoxCollider boxColliderObjetoEscudo;
		public SpriteRenderer firerender;
		public BoxCollider escudocolider;
		public MeshRenderer escudorender;
		double tiempoduracionescudo;

		double tiempofirerender;
	public AudioSource sonidostrella;
	public Text texto;
	int privado;

	// Use this for initialization
	void Start () {
		tiempoduracionescudo=0;
		tiempofirerender=1500;
		privado=0;

		if(globalvariables.escudocomprado==true){
			renderObjetoEscudo.enabled=true;
			boxColliderObjetoEscudo.enabled=true;
		}else{
			renderObjetoEscudo.enabled=false;
			boxColliderObjetoEscudo.enabled=false;
		}


	if(PlayerPrefs.HasKey("valormeteoro")){
			valormeteoro=PlayerPrefs.GetInt("valormeteoro");
		}else{
			valormeteoro=1;
			PlayerPrefs.SetInt("valormeteoro",1);
		}





		if(PlayerPrefs.HasKey("maxbalas")){
			limitedebalas=PlayerPrefs.GetInt("maxbalas");

		}else{
			limitedebalas=30;
			PlayerPrefs.SetInt("maxbalas",30);
		}

	if(PlayerPrefs.HasKey("resistenciaEscudo")){
		 resistenciaEscudo=0;
		int iresistenciaEscudo;
			iresistenciaEscudo=PlayerPrefs.GetInt("resistenciaEscudo");
		resistenciaEscudo=iresistenciaEscudo;
		}else{
			resistenciaEscudo=0;
			PlayerPrefs.SetInt("resistenciaEscudo",0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		texto.text=""+globalvariables.puntos;

		

			tiempofirerender=tiempofirerender+Time.time;
			if(tiempofirerender<1000){firerender.enabled=true;
			}else{firerender.enabled=false;}
			nivel2.revisalevel=false;
		
		if(escudorender.enabled==true){
			tiempoduracionescudo+=Time.time;

			if(tiempoduracionescudo>resistenciaEscudo){
				escudorender.enabled=false;
				escudocolider.enabled=false;
				tiempoduracionescudo=0;
			}
		}
		
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


	void cargabalasN(){
			globalvariables.nbalas+=5;
			
			
			
			globalvariables.puededisparar=true;
			if(globalvariables.nbalas>limitedebalas){globalvariables.nbalas=limitedebalas;}

	}
	void OnTriggerEnter(Collider other){
				if(other.tag=="star"){ 
					
			other.transform.position=new Vector3(Random.Range(transform.position.x-0.4f,transform.position.x+0.4f),Random.Range(8.5f,10f),transform.position.z-120f);
			
			globalvariables.puntos+=valormeteoro;
			//privado++;
			//texto.text=""+globalvariables.newstars+"ff";
			

			if(globalvariables.velocidad<2.5f){
			globalvariables.velocidad=globalvariables.velocidad*1.25f; //.04f
			}
			
			
//			vel.text=""+(globalvariables.velocidad*1000)+"km/h" +"--"+ vida +"%";
			cargabalasN();
			//mueveydispara.cargabalas();
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
	
		if(other.tag=="activaescudo"){
			escudocolider.enabled=true;
			escudorender.enabled=true;


		}

	}

	
	
}
