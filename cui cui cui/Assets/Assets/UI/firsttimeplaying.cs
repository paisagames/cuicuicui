using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firsttimeplaying : MonoBehaviour {
public Image velocity;
public Image move;
public Image shoot;
	// Use this for initialization
	void Start () {

		if(PlayerPrefs.HasKey("firstime3")){
			velocity.enabled=false;
			move.enabled=false;
			shoot.enabled=false;

		}else{

			velocity.enabled=true;
			move.enabled=true;
			shoot.enabled=true;

			PlayerPrefs.SetString("firstime3","firstime2");


		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void quitashoot(){
		if(shoot.enabled==true){
		shoot.enabled=false;}
	}
	public void quitamove(){
		if(move.enabled==true){
		move.enabled=false;}
	}

	public void quitavel(){
		if(velocity.enabled==true){
		velocity.enabled=false;}
	}
}
