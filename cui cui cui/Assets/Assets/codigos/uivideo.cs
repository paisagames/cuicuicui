using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uivideo : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetString("Iniciaintro")=="FALSE"){
			text.text="OFF";
		}else{text.text="ON";}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void videointrometodo(){
		if(PlayerPrefs.GetString("Iniciaintro")=="FALSE"){
			text.text="ON";
			PlayerPrefs.SetString("Iniciaintro","TRUE");
		}else{
			PlayerPrefs.SetString("Iniciaintro","FALSE");
			text.text="OFF";
		}
	}

}
