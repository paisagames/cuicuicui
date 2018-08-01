using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerealien : MonoBehaviour {
	public AudioSource sonidomuere;
	public Transform nave;
	public static bool restartbool;

	float fuerzabala;
	//double tiempodispara;
//	public  Rigidbody projectil;
	
	//public Transform puntodelanzamiento;
	//public MeshRenderer alienrender;
	//public MeshRenderer alienrender2;
	//public MeshRenderer alienrender3;
//	public MeshRenderer alienrenderbala;
	//public SpriteRenderer cuborender;
	int valormeteoro;
	float vidaalien;
	float extravidaalien;
	public Transform cubovida;

	//public MeshRenderer cubovidarender;
	double tiempodedisparo2;
	// Use this for initialization
	void Start () {

	if(PlayerPrefs.HasKey("valormeteoro")){
			valormeteoro=PlayerPrefs.GetInt("valormeteoro");
		}else{
			valormeteoro=1;
			PlayerPrefs.SetInt("valormeteoro",1);
		}


		globalvariables.shootalienactivo=true;
		globalvariables.shooteralien=false;
		vidaalien=10f;
		//tiempodispara=0;
		//tiempodedisparo2=0;
		restartbool=false;
		extravidaalien=5f;

		fuerzabala=1f;

		if(PlayerPrefs.HasKey("fuerzabala")){
			fuerzabala=PlayerPrefs.GetFloat("fuerzabala");
		}else{
			fuerzabala=1f;
			PlayerPrefs.SetFloat("fuerzabala",1f);
		}


	}
	
	// Update is called once per frame

	public void restart(){
		globalvariables.shooteralien=false;
			//alienrender.enabled=false;
			vidaalien=0;
			//cubovidarender.enabled=false;
			globalvariables.shooteralien=true;
			}
	void Update () {
		//cubovida.transform.localScale=new Vector3((vidaalien*0.1f)/13,0.01f,0.001f);



			

		if(restartbool==true){
			restart();
			restartbool=false;
		}



		switch(globalvariables.puntos){
			case 20:globalvariables.shooteralien=true;vidaalien=10f;break;
			case 50:globalvariables.shooteralien=true;vidaalien=20f;break;
			case 100:globalvariables.shooteralien=true;vidaalien=40f;break;
			case 200:globalvariables.shooteralien=true;vidaalien=100f;break;
			case 350:globalvariables.shooteralien=true;vidaalien=300f;break;
			

		}
		
		if(vidaalien<=0){
			sonidomuere.Play();
			transform.position=new Vector3(nave.position.x+10f,transform.position.y,nave.position.z-520f);
			vidaalien=10f+extravidaalien;
			extravidaalien+=5f;
			cubovida.transform.localScale=new Vector3((vidaalien*0.1f)/13,0.2f,0.001f);
			globalvariables.puntos+= (valormeteoro*5);

			///mover la nave del alien a mas adelante de la nave normal
			// que vuelva a su vida original la nave alien
			//cubovida.transform.localScale=new Vector3((vidaalien*0.1f)/13,0.01f,0.001f);
			
		}

		if(globalvariables.shooteralien==true){

			//alienrender.enabled=true;
			//alienrender2.enabled=true;
			//alienrender3.enabled=true;
			//alienrenderbala.enabled=true;
			//cuborender.enabled=true;
			
		}
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="bala"){

		float armo=0f;
	
		//transform.position=new Vector3(Random.Range(-2f,20f),Random.Range(0f,10f),other.transform.position.z-20f);
		
			vidaalien-=fuerzabala;
			
			cubovida.transform.localScale=new Vector3((vidaalien*0.1f)/13,0.2f,0.001f);

			
			}
}
}
