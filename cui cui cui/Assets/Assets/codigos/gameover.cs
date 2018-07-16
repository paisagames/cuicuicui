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
		
		SceneManager.LoadScene("loose");
		avanza.vida=10f;
		//menui.enabled=true;
		//menut.enabled=true;

	}	
	}

	public void reiniciar(){
		SceneManager.LoadScene("escena1");
		avanza.vida=100f;

	}
}
