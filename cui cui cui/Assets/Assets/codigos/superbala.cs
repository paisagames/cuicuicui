using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class superbala : MonoBehaviour {


	public Text texto;
		// Use this for initialization
	public Image imagenvida;
	void Start () {
		texto.text="vida"+avanza.vida;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		texto.text="vida"+avanza.vida+"tag="+other.tag;
		if(other.tag=="Playerbody"){
			avanza.vida-=0.05f;
			texto.text="vida"+avanza.vida+"tag="+other.tag+"SIIIIIII";
			imagenvida.rectTransform.sizeDelta = new Vector2(avanza.vida, 100f);
			
		}
	}
}
