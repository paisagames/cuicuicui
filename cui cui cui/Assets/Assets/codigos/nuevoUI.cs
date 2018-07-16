using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nuevoUI : MonoBehaviour {
	public Text sonido;
	

	// Use this for initialization
	void Start () {
		//globalvariables.sonidoactivadobool=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void iniciarjuego(){
		SceneManager.LoadScene("escena1");
		
	}
	public void sonidoactivado(){
		if(globalvariables.sonidoactivadobool==false){globalvariables.sonidoactivadobool=true;sonido.text="MUSIC:ON";}
		else{globalvariables.sonidoactivadobool=false;sonido.text="MUSIC:OFF";}
	}
}
