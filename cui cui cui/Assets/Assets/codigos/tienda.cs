using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tienda : MonoBehaviour {

public Sprite nave_sola;
public Sprite nave_lapiz;
public Sprite balista_1;
public Sprite balista_2;
public Sprite balista_3;

public Sprite salud_1;
public Sprite salud_2;

public Sprite salud_3;


public Button boton_siguient;
public Button boton_anterior;
public Text startext;

public Image imagenmuestra;




int imagenactual;



	// Use this for initialization
	void Start () {


		imagenactual=1;
		imagenmuestra.sprite=nave_lapiz;
		
		
		

			//stars
		if(PlayerPrefs.HasKey("stars")){
			int estrellas=PlayerPrefs.GetInt("stars");
			startext.text="$"+estrellas;

		}else{
			PlayerPrefs.SetInt("stars",0);
			int estrellas=PlayerPrefs.GetInt("stars");
			startext.text="$"+estrellas;
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


			

			}







		



	}


//IMPRIME METODO
	
	void cambiaimagen(){
		switch(imagenactual){
			case 1:imagenmuestra.sprite=balista_1;break;
			case 2:imagenmuestra.sprite=balista_2;break;
			case 3:imagenmuestra.sprite=balista_3; break;
			case 4:imagenmuestra.sprite=salud_1;break;
			case 5:imagenmuestra.sprite=salud_2;break;
			case 6:imagenmuestra.sprite=salud_3;break;
			case 7:imagenmuestra.sprite=nave_lapiz;break;
			case 8:imagenmuestra.sprite=nave_sola;break;

		}


		
			

	}

	public void siguiente(){
		if(imagenactual>1){imagenactual--;}else{imagenactual=8;}
		cambiaimagen();
	}
	public void anterior(){
		if(imagenactual<8){imagenactual++;}else{imagenactual=1;}
		cambiaimagen();
	}













	

}
