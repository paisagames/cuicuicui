using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shooteralien2 : MonoBehaviour {

	// Use this for initialization
	//public Text textprintdistance;
	public AudioSource disparoSound;
	public static float vida;
	public Transform objetivo;
	public Transform puntodelanzamiento;
	public Rigidbody projectil;

	double tiempo;
	void Start () {
		vida=100;
		tiempo=0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.pausado==false){
		float distancia=Vector3.Distance(objetivo.position,transform.position);
			//textprintdistance.text="distancia:"+distancia;
		transform.LookAt(objetivo);
		tiempo=tiempo+Time.time;
		if(tiempo>350){
			if(distancia<120){

		Rigidbody instantiatedProjectile = Instantiate (projectil, puntodelanzamiento.position, projectil.rotation) as Rigidbody;

			instantiatedProjectile.velocity=transform.TransformDirection(new Vector3(0,0,90f));
			if(globalvariables.sonidoactivadobool==true){
				disparoSound.Play();
				}
			}
			tiempo=0;
			
	//vidat.text="vida:"+vida;
		}
		}
	
	}
	
	}
	

