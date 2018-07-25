using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tienda : MonoBehaviour {

public Sprite nave_sola;
public Sprite nave_lapiz;
public Sprite balista_1;

public Sprite salud_1;



public Button boton_siguient;
public Button boton_anterior;
public Text startext;

public Image imagenmuestra;


public Text life;
public Text bulletpower;
public Text totalstars;
public Text rank;


public Text pencilpowertext;
public Text rancktext;

//precios
int preciovida;
int preciolapiz;
int precioArmas;


int imagenactual;

//fuerzas
float fuerzabala;
float fuerzalapiz;
float vida;
int totalstarsint;

public Button botonlapiz;
public Image imagelapiz;
public Text textlapiz;

public Text precioACTUALtext;

int estrellas;



	// Use this for initialization
	void Start () {


		imagenactual=1;
		imagenmuestra.sprite=balista_1;
		precioACTUALtext.text="ZERO";
		
		
		

			//stars
		if(PlayerPrefs.HasKey("stars")){
			estrellas=PlayerPrefs.GetInt("stars");
			startext.text="$"+estrellas;

		}else{
			PlayerPrefs.SetInt("stars",0);
			estrellas=PlayerPrefs.GetInt("stars");
			startext.text="$"+estrellas;
		}

		if(PlayerPrefs.HasKey("precioVida")){
			preciovida=PlayerPrefs.GetInt("precioVida");
		}else{
			preciovida=120;
			PlayerPrefs.SetInt("precioVida",120);
		}

		if(PlayerPrefs.HasKey("precioLapiz")){
			preciolapiz=PlayerPrefs.GetInt("precioLapiz");
			
		}else{
			preciolapiz=300;
			PlayerPrefs.SetInt("precioLapiz",300);
			PlayerPrefs.SetString("lapizcomprado","false");
		}

		if(PlayerPrefs.HasKey("precioArmas")){
			precioArmas=PlayerPrefs.GetInt("precioArmas");
		}else{
			precioArmas=150;
			PlayerPrefs.SetInt("precioArmas",150);
		}

		if(PlayerPrefs.HasKey("fuerzabala")){
			fuerzabala=PlayerPrefs.GetFloat("fuerzabala");
		}else{
			fuerzabala=0f;
			PlayerPrefs.SetFloat("fuerzabala",0f);
		}

		if(PlayerPrefs.HasKey("fuerzalapiz")){
			fuerzalapiz=PlayerPrefs.GetFloat("fuerzalapiz");
		}else{
			fuerzalapiz=0f;
			PlayerPrefs.SetFloat("fuerzalapiz",0f);
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

		if(PlayerPrefs.HasKey("lapizBool")){
			///aqui poner si el lapiz esta activo
			string lapizBoolstring=PlayerPrefs.GetString("lapizBool");
			if(lapizBoolstring=="true"){
				globalvariables.lapizboolactivado=true;
				imagenmuestra.sprite=nave_lapiz;

			}else{globalvariables.lapizboolactivado=false;
			imagenmuestra.sprite=nave_sola;}
		}else{
			PlayerPrefs.SetString("lapizBool","false");
			globalvariables.lapizboolactivado=false;
		}
		if(PlayerPrefs.HasKey("lapizcomprado")){
			string stringlapizcomprado=PlayerPrefs.GetString("lapizcomprado");
			if(stringlapizcomprado=="true"){
				globalvariables.lapizcomprado=true;
			}else{
				globalvariables.lapizcomprado=false;
			}


		}else{globalvariables.lapizcomprado=false;}
		
	imprimetodo();
		
	}
	
	// Update is called once per frame
	void Update () {

			if(Input.GetKeyDown(KeyCode.R)){
			PlayerPrefs.SetInt("precioVida",100);
			PlayerPrefs.SetInt("precioLapiz",100);
			PlayerPrefs.SetInt("precioArmas",100);
			PlayerPrefs.SetInt("stars",110);
			PlayerPrefs.SetFloat("fuerzabala",0);
			PlayerPrefs.SetFloat("fuerzalapiz",10);
			PlayerPrefs.SetFloat("vida",0);
			PlayerPrefs.SetInt("totalstars",0);


			

			}


	}//termmina Update

//IMPRIME METODO
void imprimetodo(){
	life.text="Life "+vida+avanza.vida;
	bulletpower.text="Bullet power "+fuerzabala;
	totalstars.text="Total stats "+totalstarsint;
	pencilpowertext.text="Pencil power "+fuerzalapiz;
	rancktext.text="Rank A";
	PlayerPrefs.SetInt("precioVida",preciovida);
	PlayerPrefs.SetInt("precioLapiz",preciolapiz);
	PlayerPrefs.SetInt("precioArmas",precioArmas);

	string lapizBoolstring=PlayerPrefs.GetString("lapizBool");
	if(lapizBoolstring=="true"){
		imagenmuestra.sprite=nave_lapiz;
	}else{imagenmuestra.sprite=nave_sola;}
	


	
}









	public void compraVida(){
		if(estrellas>=preciovida){
			estrellas-=preciovida;
			vida=vida*1.20f;
			PlayerPrefs.SetFloat("vida",vida);
			double aumento=preciovida*1.20;
			preciovida=(int)aumento;
			imprimetodo();

		}



	}


	public void compraBullets(){
		if(estrellas>=precioArmas){
			estrellas-=precioArmas;
			fuerzabala=fuerzabala*1.20f;
			PlayerPrefs.SetFloat("fuerzabala",fuerzabala);
			double aumento=precioArmas*1.20;
			precioArmas=(int)aumento;
			imprimetodo();

		}



	}


	public void compraLapiz(){
if(estrellas>=preciolapiz){
		if(globalvariables.lapizcomprado==false){
			globalvariables.lapizcomprado=true;PlayerPrefs.SetString("lapizcomprado","true");
			botonlapiz.enabled=true;
		imagelapiz.enabled=true;
		textlapiz.enabled=true;
		
		
		}
		
			if(globalvariables.lapizboolactivado==false){

			estrellas-=precioArmas;
			globalvariables.lapizboolactivado=true;
			PlayerPrefs.SetString("lapizBool","true");
			double aumento=preciolapiz*1.20;
			preciolapiz=(int)aumento;
			imprimetodo();
			}
		}
	}

	public void cambiaimagenalapiz(){
		if(imagenmuestra.sprite==nave_lapiz){imagenmuestra.sprite=nave_sola;}else{
			imagenmuestra.sprite=nave_lapiz;
		}


	}



	
	void cambiaimagen(){
		switch(imagenactual){
			case 1:imagenmuestra.sprite=balista_1;precioACTUALtext.text=""+precioArmas;break;
			case 2:imagenmuestra.sprite=salud_1;precioACTUALtext.text=""+preciovida;break;
			case 3:imagenmuestra.sprite=nave_lapiz;precioACTUALtext.text=""+preciolapiz; break;
			case 4:imagenmuestra.sprite=nave_sola;precioACTUALtext.text="ZERO";break;
		

		}


		
			

	}

	public void siguiente(){
		if(imagenactual<4){imagenactual++;}else{imagenactual=1;}
		
		cambiaimagen();
	}
	public void anterior(){
		if(imagenactual>1){imagenactual--;}else{imagenactual=4;}
		cambiaimagen();
	}













	

}
