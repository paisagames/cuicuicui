using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {
	/*public Image gameoverimage;
	public Button reiniciar;
	public Text reiniciart;
	public Image reiniciarI;
	public Button menu;
	public Text menut;
	public Image menui;*/
	// Use this for initialization
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if(avanza.vida<=0f){
		if(PlayerPrefs.HasKey("stars")){
				int stars=PlayerPrefs.GetInt("stars");
				stars=stars+globalvariables.puntos;
				PlayerPrefs.SetInt("stars",stars);
				SceneManager.LoadScene("loose");
				avanza.vida=10f;
		}else{
			PlayerPrefs.SetInt("stars",globalvariables.puntos);
				SceneManager.LoadScene("loose");
				avanza.vida=10f;
			}
		

		//menui.enabled=true;
		//menut.enabled=true;

	}	
	}

	
}
