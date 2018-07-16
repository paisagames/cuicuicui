using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class avanza : MonoBehaviour {

	bool avionherido;
	public MeshRenderer avionmeshrender;
	public Material redmaterial;
	public Material cruzrojamaterial;
	public Text textmaxpunt;
	public AudioSource sonidopiedra;
	public AudioSource sonidostrella;

	public AudioSource sonidohealth;
	public static float vida=100f;
	public Image imagenvida;

	double tiempomateriales;
	public Transform empty;
		int maxpunt;
		public Text textpuntos;
		public Text vel;
		
		public static float velocidad;
		double tiempoajuste;
		float posicionZ;
	// Use this for initialization
	void Start () {
		avionherido=false;
		tiempomateriales=0;
		posicionZ=transform.localPosition.z;

		tiempoajuste=0;
		maxpunt=0;
		if(PlayerPrefs.HasKey("max")==true){
			maxpunt=PlayerPrefs.GetInt("max");

		}else{
			PlayerPrefs.SetInt("max",maxpunt);

		}
		globalvariables.gameOn=false;
		globalvariables.puntos=0;
		globalvariables.velocidad=0.00f; //0.05f
		vel.text=""+(globalvariables.velocidad*1000)+"km/h" +"--"+ vida +"%";
		
	}
	
	// Update is called once per frame

	
	void Update () {
		
		if(globalvariables.pausado==false){
		if(globalvariables.velocidad<=0.2f){
			globalvariables.velocidad+=0.02f;
		}
		}else{
			globalvariables.velocidad=0;
		}

		if(Input.GetKeyDown(KeyCode.K)){
			globalvariables.puntos++;
		}
		//ajusta la nave en z
		tiempoajuste=tiempoajuste+Time.time;

		
		if(avionherido==true){
			tiempomateriales=tiempomateriales+Time.time;
			if(tiempomateriales>300){
				avionmeshrender.material=cruzrojamaterial;
			
				tiempomateriales=0;
				avionherido=false;

			}

		}




		//transform.Translate(0,0,globalvariables.velocidad);
		vel.text=""+(globalvariables.velocidad*1000)+"km/h" +"--"+ vida +"%";
		textpuntos.text=""+globalvariables.puntos;
		textmaxpunt.text="MAX:"+PlayerPrefs.GetInt("max");
	}

	void OnTriggerEnter(Collider other){
		if(other.tag=="star"){
			other.transform.position=new Vector3(Random.Range(transform.position.x-0.4f,transform.position.x+0.4f),Random.Range(0f,10f),transform.position.z-120f);
			globalvariables.puntos++;
			textpuntos.text=""+globalvariables.puntos;
			globalvariables.velocidad=globalvariables.velocidad*1.25f; //.04f
			
			vel.text=""+(globalvariables.velocidad*1000)+"km/h" +"--"+ vida +"%";
			mueveydispara mueveydispara=new mueveydispara();
			mueveydispara.cargabalas();
			if(globalvariables.sonidoactivadobool==true){
			sonidostrella.Play();}

			if(globalvariables.puntos>PlayerPrefs.GetInt("max")){
				PlayerPrefs.SetInt("max",globalvariables.puntos);
			}


		}
		if(other.tag=="balaalien"){
		//	vida-=40f;
			imagenvida.rectTransform.sizeDelta = new Vector2(vida, 100f);
			avionmeshrender.material=redmaterial;
			avionherido=true;
			

		}

		if(other.tag=="bola"){
			vida-=30f;
			globalvariables.velocidad=0f;
			other.transform.position=new Vector3(Random.Range(-2f,20f),Random.Range(0f,10f),transform.position.z-120f);
			imagenvida.rectTransform.sizeDelta = new Vector2(vida, 100f);
				vel.text=""+(globalvariables.velocidad*1200)+"km/h" +"--"+ vida +"%";
				if(globalvariables.sonidoactivadobool==true){
			sonidopiedra.Play();}

			avionmeshrender.material=redmaterial;
			avionherido=true;


		}
		if(other.tag=="vida"){
			if(globalvariables.sonidoactivadobool==true){
			sonidohealth.Play();}

			vida+=50f;
			if(vida>=100f){vida=100f;}
			imagenvida.rectTransform.sizeDelta = new Vector2(vida, 100f);
			vel.text=""+(globalvariables.velocidad*1000)+"km/h" +"--"+ vida +"%";
		}
		if(vida<0f){vida=0f;globalvariables.gameOn=false;}

	}
}
