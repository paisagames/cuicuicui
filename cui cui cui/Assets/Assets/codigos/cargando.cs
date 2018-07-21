using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cargando : MonoBehaviour {
	double tiempo;
	bool tiempobool;
	public Image cargandoimg;
	public Text text1;
	public Text text2;
	public Text text3;
	public Image imagen1;
	public Image imagen2;

	public Image storeimg;
	public Text textstore;
	

	// Use this for initialization
	void Start () {
		tiempo=0;
		tiempobool=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(tiempobool==true){
			tiempo=tiempo+Time.time;
		}
		if(tiempo>200){
		SceneManager.LoadScene("escena1");
		}
		
	}
	public void cargaahora(){
		storeimg.enabled=false;
		textstore.enabled=false;
		text1.enabled=false;
		text2.enabled=false;
		text3.enabled=false;
		imagen1.enabled=false;
		imagen2.enabled=false;
		cargandoimg.enabled=true;
		tiempobool=true;
		

	}

	

}
