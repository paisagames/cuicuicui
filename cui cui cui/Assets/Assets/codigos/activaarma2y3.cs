using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activaarma2y3 : MonoBehaviour {
	int cantidaddearmas;
	//public Renderer arma2rend;
	//public GameObject arma3;

	// Use this for initialization
	void Start () {
		cantidaddearmas=1;
		if(PlayerPrefs.HasKey("cantidaddearmas")){
			cantidaddearmas=PlayerPrefs.GetInt("cantidaddearmas");
		}else{cantidaddearmas=1;}


		switch(cantidaddearmas){
			case 1:globalvariables.arma2activa=false;globalvariables.arma3activa=false;break;
			case 2:globalvariables.arma2activa=true;globalvariables.arma3activa=false;break;
			case 3:globalvariables.arma2activa=true;globalvariables.arma3activa=true;break;
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
