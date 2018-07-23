using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tienda : MonoBehaviour {

public Text startext;

public Text textpreciovida;
public Text textprecioarmas;
public Text textpreciovelocidad;


public Text textoCantidadvida;
public Text textoCantidadvelocidad;
public Text textoCantidadarmas;


int intpreciovida;
int intprecioarmas;
int intpreciovelocidad;
	// Use this for initialization
	void Start () {
		imprimeMETODO();

			//stars
		if(PlayerPrefs.HasKey("stars")){
			int estrellas=PlayerPrefs.GetInt("stars");
			startext.text="$"+estrellas;

		}else{
			PlayerPrefs.SetInt("stars",0);
			int estrellas=PlayerPrefs.GetInt("stars");
			startext.text="$"+estrellas;
		}


		//PRECIO VIDA
		if(PlayerPrefs.HasKey("precioVida")){
			intpreciovida=PlayerPrefs.GetInt("precioVida");
			textpreciovida.text="$"+intpreciovida;

		}else{
			PlayerPrefs.SetFloat("precioVida",100);
			intpreciovida=100;
			textpreciovida.text="$"+intpreciovida;
		}
		//PRECIOARMAS
		if(PlayerPrefs.HasKey("precioArmas")){
			intprecioarmas=PlayerPrefs.GetInt("precioArmas");
			textprecioarmas.text="$"+intprecioarmas;

		}else{
			PlayerPrefs.SetInt("precioArmas",100);
			intprecioarmas=100;
			textprecioarmas.text="$"+intprecioarmas;
		}

		//PRECIOVELOCIDAD
		if(PlayerPrefs.HasKey("precioVelocidad")){
			intpreciovelocidad=PlayerPrefs.GetInt("precioVelocidad");
			textpreciovelocidad.text="$"+intpreciovelocidad;

		}else{
			PlayerPrefs.SetFloat("precioVelocidad",100);
			intpreciovelocidad=100;
			textpreciovelocidad.text="$"+intpreciovelocidad;
		}


		
	}
	
	// Update is called once per frame
	void Update () {

			if(Input.GetKeyDown(KeyCode.R)){
			PlayerPrefs.SetInt("precioVida",100);
			PlayerPrefs.SetInt("precioVelocidad",100);
			PlayerPrefs.SetInt("precioArmas",100);
			PlayerPrefs.SetInt("stars",110);
			PlayerPrefs.SetInt("armo",0);
			PlayerPrefs.SetFloat("velo",0);
			PlayerPrefs.SetFloat("vida",0);


			imprimeMETODO();

			}







		



	}


//IMPRIME METODO
	
	public void imprimeMETODO(){


			int istrella=PlayerPrefs.GetInt("stars");
			int ipreciovida=PlayerPrefs.GetInt("precioVida");
			int ipreciovelocidad=PlayerPrefs.GetInt("precioVelocidad");
			int iprecioarmas=PlayerPrefs.GetInt("precioArmas");
			int iarmo=PlayerPrefs.GetInt("armo");
			float ivelo=PlayerPrefs.GetFloat("velo");
			float ivida=PlayerPrefs.GetFloat("vida");

			startext.text="$"+istrella;
			textoCantidadarmas.text=""+iarmo;
			textoCantidadvelocidad.text=""+ivelo;
			textoCantidadvida.text=""+ivida;

			textprecioarmas.text="$"+iprecioarmas;
			textpreciovelocidad.text="$"+ipreciovelocidad;
			textpreciovida.text="$"+ipreciovida;

	}











//VENDE

	public void vendevida(){
		

			int strellas=PlayerPrefs.GetInt("stars");
			float vida=PlayerPrefs.GetFloat("vida");
			

			if(vida>=20f){

		
			
			vida=vida-20f;
			PlayerPrefs.SetFloat("vida",vida);

		
			
			strellas+=intpreciovida-10;
			intpreciovida-=10;
			PlayerPrefs.SetInt("precioVida",intpreciovida);
			PlayerPrefs.SetInt("stars",strellas);

			
			}//STRELLAS>PRECIOVIDA
		

		imprimeMETODO();
	}
	public void vendearmas(){

		int strellas=PlayerPrefs.GetInt("stars");
			int armo=PlayerPrefs.GetInt("armo");
			

			if(armo>=5){

		
			
			armo=armo-5;
			PlayerPrefs.SetInt("armo",armo);

		
			
			strellas+=intprecioarmas-10;
			intprecioarmas-=10;
			PlayerPrefs.SetInt("precioArmas",intprecioarmas);
			PlayerPrefs.SetInt("stars",strellas);

			
			}//STRELLAS>PRECIOVIDA
			imprimeMETODO();

	}//float

public void vendevelocidad(){

		

			int strellas=PlayerPrefs.GetInt("stars");
			float velo=PlayerPrefs.GetFloat("velo");
			

			if(velo>=10f){

		
			
			velo=velo-10f;
			PlayerPrefs.SetFloat("velo",velo);

		
			
			strellas+=intpreciovelocidad-10;
			intpreciovelocidad-=10;
			PlayerPrefs.SetInt("precioVelocidad",intpreciovelocidad);
			PlayerPrefs.SetInt("stars",strellas);

			
			}//STRELLAS>PRECIOVIDA
		

		imprimeMETODO();

	}
	







//COMPRA MAS ABAJO






















//COMPRA
	public void compravida(){
		
	int strellas=PlayerPrefs.GetInt("stars");

			intpreciovida=PlayerPrefs.GetInt("precioVida");
			if(strellas>=intpreciovida){

			
			float vida=PlayerPrefs.GetFloat("vida");
			vida+=20f;
			PlayerPrefs.SetFloat("vida",vida);

		
			
			strellas-=intpreciovida;
			PlayerPrefs.SetInt("stars",strellas);
			intpreciovida+=10;
			PlayerPrefs.SetInt("precioVida",intpreciovida);

			
			
			
			



		}
		imprimeMETODO();
	}
	public void compraarmas(){


	int strellas=PlayerPrefs.GetInt("stars");

			intprecioarmas=PlayerPrefs.GetInt("precioArmas");
			if(strellas>=intprecioarmas){

			
			int armas=PlayerPrefs.GetInt("armo");
			armas+=5;
			PlayerPrefs.SetInt("armo",armas);

		
			
			strellas-=intprecioarmas;
			PlayerPrefs.SetInt("stars",strellas);
			intprecioarmas+=10;
			PlayerPrefs.SetInt("precioArmas",intprecioarmas);

			
			
			
			



		}
		imprimeMETODO();

	}//float

	public void compravelocidad(){


			int strellas=PlayerPrefs.GetInt("stars");

			intpreciovelocidad=PlayerPrefs.GetInt("precioVelocidad");
			if(strellas>=intpreciovelocidad){

			
			float vel=PlayerPrefs.GetFloat("velo");
			vel=vel+10f;
			PlayerPrefs.SetFloat("velo",vel);

		
			
			strellas-=intpreciovelocidad;
			PlayerPrefs.SetInt("stars",strellas);
			intpreciovelocidad+=10;
			PlayerPrefs.SetInt("precioVelocidad",intpreciovelocidad);

			
			
			
			



		}
		imprimeMETODO();


	}

}
