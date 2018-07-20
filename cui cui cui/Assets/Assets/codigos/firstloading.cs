using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class firstloading : MonoBehaviour {

	// Use this for initialization
	bool verintro;
	double tiempo;
	void Start () {
		verintro=true;
		tiempo=0;
		if(PlayerPrefs.HasKey("Iniciaintro")){
			if(PlayerPrefs.GetString("Iniciaintro")=="FALSE"){
				verintro=false;
			}else{verintro=true;}
		}else{
			PlayerPrefs.SetString("Iniciaintro","FALSE");
		verintro=true;
		}

		
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.time;
		if(tiempo>300){
			if(verintro==true){SceneManager.LoadScene("historia");}else{
				SceneManager.LoadScene("menu");

			}


		}
	
	if(Input.GetKeyDown(KeyCode.F)){
			PlayerPrefs.SetString("Iniciaintro","TRUE");
	}
	
	
	}

}
