using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tienda : MonoBehaviour {

public Sprite corazon_s;
public Sprite bala_s;
public Sprite escudo_s;

public Sprite arma_s;
public Sprite meteoro_s;
public Sprite bagbulltes_s;


public Button boton_siguient;
public Button boton_anterior;
public Text startext;

public Image imagenmuestra;


public Text life;
public Text bulletpower;
public Text totalstars;
public Text rank;


public Text shieldtext;
public Text rancktext;


public Text armastotales;

public Text starscollectvalue;
//precios
int preciovida;
int precioescudo;
int precioBullets;


int imagenactual;

//fuerzas
float fuerzabala;
int resistenciaEscudo;
float vida;
int totalstarsint;

int limitedebalas;




public Text precioACTUALtext;

public Text limitedebalastext;

int precioArmas;
int estrellas;

int valormeteoro;

int precioMeteorodoble;

int precioBAGBULLETS;



	// Use this for initialization
	void Start () {




		resistenciaEscudo=1000;	
		imagenactual=1;
		imagenmuestra.sprite=corazon_s;
		
		valormeteoro=1;
		precioMeteorodoble=500;
		limitedebalas=30;
		

			//stars
		if(PlayerPrefs.HasKey("stars")){
			estrellas=PlayerPrefs.GetInt("stars");
			startext.text="$"+estrellas;

		}else{
			PlayerPrefs.SetInt("stars",0);
			estrellas=PlayerPrefs.GetInt("stars");
			startext.text="$"+estrellas;
		}
		if(PlayerPrefs.HasKey("precioArmas")){
			precioArmas=PlayerPrefs.GetInt("precioArmas");
		}else{
			precioArmas=420;
			PlayerPrefs.SetInt("precioArmas",420);
		}


		if(PlayerPrefs.HasKey("preciometeorodoble")){
			precioMeteorodoble=PlayerPrefs.GetInt("preciometeorodoble");
		}else{
			precioMeteorodoble=2500;
			PlayerPrefs.SetInt("preciometeorodoble",2500);
		}

		if(PlayerPrefs.HasKey("valormeteoro")){
			valormeteoro=PlayerPrefs.GetInt("valormeteoro");
		}else{
			valormeteoro=1;
			PlayerPrefs.SetInt("valormeteoro",1);
		}




		if(PlayerPrefs.HasKey("precioVida")){
			preciovida=PlayerPrefs.GetInt("precioVida");
			precioACTUALtext.text=""+preciovida;
		}else{
			preciovida=120;
			PlayerPrefs.SetInt("precioVida",120);
			precioACTUALtext.text=""+preciovida;
		}

		if(PlayerPrefs.HasKey("precioEscudo")){
			precioescudo=PlayerPrefs.GetInt("precioEscudo");
			
		}else{
			precioescudo=300;
			PlayerPrefs.SetInt("precioescudo",300);
			PlayerPrefs.SetString("escudocomprado","false");
		}

		if(PlayerPrefs.HasKey("precioBullets")){
			precioBullets=PlayerPrefs.GetInt("precioBullets");
		}else{
			precioBullets=150;
			PlayerPrefs.SetInt("precioBullets",150);
		}

		if(PlayerPrefs.HasKey("fuerzabala")){
			fuerzabala=PlayerPrefs.GetFloat("fuerzabala");
		}else{
			fuerzabala=1f;
			PlayerPrefs.SetFloat("fuerzabala",1f);
		}

		if(PlayerPrefs.HasKey("resistenciaEscudo")){
			resistenciaEscudo=PlayerPrefs.GetInt("resistenciaEscudo");
		}else{
			resistenciaEscudo=0;
			PlayerPrefs.SetInt("resistenciaEscudo",0);
		}

		if(PlayerPrefs.HasKey("vida")){
			vida=PlayerPrefs.GetFloat("vida");
		}else{
			vida=0f;
			PlayerPrefs.SetFloat("vida",0f);
		}

		if(PlayerPrefs.HasKey("totalstars")){
			totalstarsint=PlayerPrefs.GetInt("totalstars");
		}else{
			totalstarsint=0;
			PlayerPrefs.SetInt("totalstars",0);
		}

		if(PlayerPrefs.HasKey("escudobool")){
			///aqui poner si el ESCUDO esta activo
			string escudoboolstring=PlayerPrefs.GetString("escudobool");
			if(escudoboolstring=="true"){
				globalvariables.escudoboolactivado=true;
				

			}else{globalvariables.escudoboolactivado=false;
			}
		}else{
			PlayerPrefs.SetString("escudobool","false");
			globalvariables.escudoboolactivado=false;
		}
		if(PlayerPrefs.HasKey("escudocomprado")){
			string stringescudocomprado=PlayerPrefs.GetString("escudocomprado");
			if(stringescudocomprado=="true"){
				globalvariables.escudocomprado=true;
			}else{
				globalvariables.escudocomprado=false;
			}


		}else{globalvariables.escudocomprado=false;}
		


		if(PlayerPrefs.HasKey("maxbalas")){
			limitedebalas=PlayerPrefs.GetInt("maxbalas");

		}else{
			limitedebalas=30;
			PlayerPrefs.SetInt("maxbalas",30);
		}

		if(PlayerPrefs.HasKey("preciobagbullets")){
			precioBAGBULLETS=PlayerPrefs.GetInt("preciobagbullets");
		}else{
				precioBAGBULLETS=250;
				PlayerPrefs.SetInt("preciobagbullets",250);

		}



	imprimetodo();
		
	}
	
	// Update is called once per frame
	void Update () {

			if(Input.GetKeyDown(KeyCode.R)){


			PlayerPrefs.SetInt("totalstars",0);
			totalstarsint=0;

			estrellas=0;
			PlayerPrefs.SetInt("stars",0);
			
			PlayerPrefs.SetInt("precioArmas",420);
			precioArmas=420;
			PlayerPrefs.SetInt("preciometeorodoble",2500);
			precioMeteorodoble=2500;
			PlayerPrefs.SetInt("precioVida",120);
			preciovida=120;
			PlayerPrefs.SetInt("precioescudo",300);
			precioescudo=300;
			PlayerPrefs.SetString("escudocomprado","false");
		
			PlayerPrefs.SetInt("precioBullets",150);
			precioBullets=150;
			PlayerPrefs.SetFloat("fuerzabala",1f);
			fuerzabala=1;
			PlayerPrefs.SetInt("resistenciaEscudo",0);
			resistenciaEscudo=0;
			globalvariables.escudocomprado=false;
			PlayerPrefs.SetFloat("vida",0f);
			vida=0;
			PlayerPrefs.SetString("escudobool","false");
		
			PlayerPrefs.SetInt("cantidaddearmas",1);
			PlayerPrefs.SetInt("maxbalas",30);
			PlayerPrefs.SetInt("valormeteoro",1);
			imprimetodo();


			

			}
			if(Input.GetKeyDown(KeyCode.T)){
				estrellas+=200;
				PlayerPrefs.SetInt("stars",estrellas);
				imprimetodo();
			}


	}//termmina Update

//IMPRIME METODO
void imprimetodo(){
	life.text="Life "+(vida+avanza.vida);
	bulletpower.text="Bullet power "+fuerzabala;

	int stars2=PlayerPrefs.GetInt("stars");
	startext.text=""+stars2;

	totalstars.text="Total stats "+totalstarsint;
	shieldtext.text="Shield Resistance "+resistenciaEscudo;

	limitedebalastext.text="Bullets Capacity "+limitedebalas;


	int cantidaddearmas=1;
			if(PlayerPrefs.HasKey("cantidaddearmas")){
				cantidaddearmas=PlayerPrefs.GetInt("cantidaddearmas");
				
			}else{
				PlayerPrefs.SetInt("cantidaddearmas",1);
				cantidaddearmas=1;
			}
	armastotales.text="Weapons "+ cantidaddearmas;

	valormeteoro=PlayerPrefs.GetInt("valormeteoro");
	starscollectvalue.text="Stars value "+valormeteoro;
	rancktext.text="Rank A";
	PlayerPrefs.SetInt("precioVida",preciovida);
	PlayerPrefs.SetInt("precioescudo",precioescudo);
	PlayerPrefs.SetInt("precioBullets",precioBullets);

	string escudoboolstring=PlayerPrefs.GetString("escudobool");

	

	cambiaimagen();
	


	
}

public void compraBAGBULLETS(){
	if(estrellas>=precioBAGBULLETS)
	{
		estrellas-=precioBAGBULLETS;
		PlayerPrefs.SetInt("stars",estrellas);
		limitedebalas+=10;
		PlayerPrefs.SetInt("maxbalas",limitedebalas);
		double aumento=precioBAGBULLETS*1.30;
			precioBAGBULLETS=(int)aumento;


			PlayerPrefs.SetInt("preciobagbullets",precioBAGBULLETS);

		imprimetodo();


	}
}









	public void compraVida(){
		if(estrellas>=preciovida){
			estrellas-=preciovida;
;
			PlayerPrefs.SetInt("stars",estrellas);

			vida=vida+50f;
			PlayerPrefs.SetFloat("vida",vida);
			double aumento=preciovida*1.30;
			preciovida=(int)aumento;


			PlayerPrefs.SetInt("precioVida",preciovida);

			imprimetodo();

		}



	}


	public void compraBullets(){
		if(estrellas>=precioBullets){
			estrellas-=precioBullets;

			
			PlayerPrefs.SetInt("stars",estrellas);


			fuerzabala=fuerzabala+1f;
			PlayerPrefs.SetFloat("fuerzabala",fuerzabala);
			double aumento=precioBullets*1.30;
			precioBullets=(int)aumento;

			PlayerPrefs.SetInt("precioBullets",precioBullets);


			imprimetodo();

		}



	}


	public void compraEscudo(){
		if(estrellas>=precioescudo){
		if(globalvariables.escudocomprado==false){
			globalvariables.escudocomprado=true;PlayerPrefs.SetString("escudocomprado","true");
			
		
		
		
		}
		
			
					if(resistenciaEscudo<1000){
						resistenciaEscudo=1000;}
					double aumenta=resistenciaEscudo*1.2;
					resistenciaEscudo=(int)aumenta;
			estrellas-=precioescudo;
			PlayerPrefs.SetInt("stars",estrellas);
			
		PlayerPrefs.SetInt("resistenciaEscudo",resistenciaEscudo);
			

			globalvariables.escudoboolactivado=true;
			PlayerPrefs.SetString("escudobool","true");
			double aumento=precioescudo*1.20;
			precioescudo=(int)aumento;

			PlayerPrefs.SetInt("precioescudo",precioescudo);
		
			
		}
		imprimetodo();
	}

	public void compraArma(){
		if(estrellas>=precioArmas){
			int cantidaddearmas=1;
			if(PlayerPrefs.HasKey("cantidaddearmas")){
				cantidaddearmas=PlayerPrefs.GetInt("cantidaddearmas");
				
			}else{
				PlayerPrefs.SetInt("cantidaddearmas",1);
				cantidaddearmas=1;
			}
			cantidaddearmas++;
			PlayerPrefs.SetInt("cantidaddearmas",cantidaddearmas);

			estrellas-=precioArmas;
			PlayerPrefs.SetInt("stars",estrellas);




			double aumento=precioArmas*1.70;
			precioArmas=(int)aumento;
			PlayerPrefs.SetInt("precioArmas",precioArmas);
		
	imprimetodo();
		}
	}

	public void compraMeteorodoble(){
		if(estrellas>=precioMeteorodoble){
			valormeteoro*=2;
			PlayerPrefs.SetInt("valormeteoro",valormeteoro);

			estrellas-=precioMeteorodoble;
			PlayerPrefs.SetInt("stars",estrellas);

			double aumento=precioMeteorodoble*3.40;
			precioMeteorodoble=(int)aumento;
			PlayerPrefs.SetInt("preciometeorodoble",precioMeteorodoble);
		}
			imprimetodo();

	}

	


	
	void cambiaimagen(){
		switch(imagenactual){
			case 1:imagenmuestra.sprite=corazon_s;precioACTUALtext.text=""+preciovida;break;
			case 2:imagenmuestra.sprite=bala_s;precioACTUALtext.text=""+precioBullets;break;
			case 3:imagenmuestra.sprite=escudo_s;precioACTUALtext.text=""+precioescudo; break;
			case 4:imagenmuestra.sprite=arma_s;precioACTUALtext.text=""+precioArmas;break;
			case 5:imagenmuestra.sprite=meteoro_s;precioACTUALtext.text=""+precioMeteorodoble;break;
			case 6:imagenmuestra.sprite=bagbulltes_s;precioACTUALtext.text=""+precioBAGBULLETS;break;

		}


		
			

	}

	public void realizCompras(){
		switch(imagenactual){
			case 1:compraVida();break;
			case 2:compraBullets();break;
			case 3:compraEscudo();break;
			case 4: compraArma();break;
			case 5: compraMeteorodoble();break;
			case 6:compraBAGBULLETS();break;

		}

	}

	public void siguiente(){
		if(imagenactual<6){imagenactual++;}else{imagenactual=1;}
		
		cambiaimagen();
	}
	public void anterior(){
		if(imagenactual>1){imagenactual--;}else{imagenactual=6;}
		cambiaimagen();
	}













	

}
