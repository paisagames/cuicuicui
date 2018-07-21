using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class firstloading : MonoBehaviour {

	// Use this for initialization
	string verintro;
	double tiempo;
	void Start () {
		verintro="true";
		tiempo=0;
		if(PlayerPrefs.HasKey("Iniciaintro")){
			string stringf=PlayerPrefs.GetString("Iniciaintro");
			switch(stringf){
				case "FALSE":verintro="false";break;
				case "TRUE":verintro="true";break;
				case "FALSEPOLI":verintro="truePOLI";break;
			}
		}else{
			PlayerPrefs.SetString("Iniciaintro","FALSEPOLI");
		verintro="truePOLI";
		}

		
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.time;
		if(tiempo>300){
			switch(verintro){
				case "true":SceneManager.LoadScene("historia");break;
				case "truePOLI":PlayerPrefs.SetString("Iniciaintro","FALSE");SceneManager.LoadScene("politica");break;
				case "false":SceneManager.LoadScene("menu");break;
			}
			


		}
	
	if(Input.GetKeyDown(KeyCode.F)){
			PlayerPrefs.SetString("Iniciaintro","FALSEPOLI");
	}
	
	
	}
	

}
