using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nuevoUI : MonoBehaviour {
	public Text sonido;
	public Text textostrellas;
	

	// Use this for initialization
	void Start () {
		//globalvariables.sonidoactivadobool=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.HasKey("stars")){
				textostrellas.text="Stars:"+PlayerPrefs.GetInt("stars");
		}else{
			PlayerPrefs.SetInt("stars",0);
				
			}
		
	}
	public void iniciarjuego(){
		SceneManager.LoadScene("escena1");
		
	}
	public void sonidoactivado(){
		if(globalvariables.sonidoactivadobool==false){globalvariables.sonidoactivadobool=true;sonido.text="MUSIC:ON";}
		else{globalvariables.sonidoactivadobool=false;sonido.text="MUSIC:OFF";}
	}
}
