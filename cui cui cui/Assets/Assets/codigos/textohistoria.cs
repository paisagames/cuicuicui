using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textohistoria : MonoBehaviour {
	public Text texto;
	int textoN;

	// Use this for initialization
	void Start () {
		textoN=0;
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(textoN){
			case 0:texto.text="Hello Pilot...";break;
			case 1:texto.text="Welcome to the Cui cui cui Spaceship..";break;
			case 2:texto.text="You don´t have to worry for this message too much, It won´t appear again the next time you open the app..";break;
			case 3:texto.text="..you were selected Pilot..";break;
			case 4:texto.text="A tremendous problem happened in the space 2 weeks ago and is your mission to help us..";break;
			case 5:texto.text="Of course this mission is completly secret..";break;
			case 6:texto.text="..we have choose only our best pilots to do this job..";break;
			case 7:texto.text="As I was telling you, 2 weeks ago an unknown Enemy appear in the orbit.";break;
			case 8:texto.text="He destroyed the spaceship A00397463... We think a part of the crew is still alive..";break;
			case 9:texto.text=".. is your job to travel throw this hole galaxy and rescue those people and discover what happened.";break;
			case 10:texto.text="..remember that we don´t know what can be outside.";break;
		}

		
	}
	public void nextmetodo(){
		textoN++;
		switch(textoN){
			case 0:texto.text="Hello Pilot...";break;
			case 1:texto.text="Welcome to the Cui cui cui Spaceship..";break;
			case 2:texto.text="You don´t have to worry for this message too much, It won´t appear again the next time you open the app..";break;
			case 3:texto.text="..you were selected Pilot..";break;
			case 4:texto.text="A tremendous problem happened in the space 2 weeks ago and is your mission to help us..";break;
			case 5:texto.text="Of course this mission is completly secret..";break;
			case 6:texto.text="..we have choose only our best pilots to do this job..";break;
			case 7:texto.text="As I was telling you, 2 weeks ago an unknown Enemy appear in the orbit.";break;
			case 8:texto.text="He destroyed the spaceship A00397463... We think a part of the crew is still alive..";break;
			case 9:texto.text=".. is your job to travel throw this hole galaxy and rescue those people and discover what happened.";break;
			case 10:texto.text="..remember that we don´t know what can be outside.";break;
			case 11:SceneManager.LoadScene("menu");break;
		}
	}
}
