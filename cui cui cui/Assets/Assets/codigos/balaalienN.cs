using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class balaalienN : MonoBehaviour {
//	public Text vidat;

public MeshRenderer r1;
public MeshRenderer r2;
public MeshRenderer r3;
	//public Image imagenvida;
	float vida;
	// Use this for initialization
	void Start () {
		//vidat.text="vida:"+vida;
		//vida=100f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="Player"){
			transform.position=new Vector3(0,1000f,0);
			avanza.vida-=1f;//shooteralien2.vida--;
			if(globalvariables.velocidad>1f){
			globalvariables.velocidad-=0.2f;}
		//	vidat.text="vida:"+avanza.vida;//vidat.text="vida:"+shooteralien2.vida;
//			imagenvida.rectTransform.sizeDelta = new Vector2(avanza.vida, 100f);
			r1.enabled=false;
			r2.enabled=false;
			r3.enabled=false;
			//MeshRenderer meshrender=transform.GetComponent<MeshRenderer>();
			//meshrender.enabled=false;
		}
		if(other.tag=="bola"){
			transform.position=new Vector3(0,1000f,0);
			

			r1.enabled=false;
			r2.enabled=false;
			r3.enabled=false;
			//MeshRenderer meshrender=transform.GetComponent<MeshRenderer>();
			//meshrender.enabled=false;

			
			//Renderer render=transform.GetComponent<Renderer>();
		//	render.enabled=false;
		}
	}
}
