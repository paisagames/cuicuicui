using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nivel2 : MonoBehaviour {
	public Text textlevel;
	public Text textlevel2;
public MeshRenderer skyrender;
public Material material2;

public Material material3;

public Material material4;

public Material material5;
public Transform esfera;
public Animator animaciontext;

//public Animator animaciontext2;
double tiempoinicio;
Vector2 posicionlevel;
bool met;

int levelanterior;
public static bool revisalevel;
	// Use this for initialization
	void Start () {
		levelanterior=0;
		revisalevel=false;
		met=false;
		tiempoinicio=0;
		globalvariables.level=1;
		posicionlevel=textlevel.transform.position;
		animaciontext.SetInteger("accion",1);
		//animaciontext2.SetInteger("accion",1);
		
	}
	
	// Update is called once per frame
	public void metodorevisa(){

		if(globalvariables.puntos>=20&&globalvariables.puntos<50){MeshRenderer mesh= esfera.GetComponent<MeshRenderer>();
			mesh.material=material2;
			globalvariables.level=2;}

			if(globalvariables.puntos>=50&&globalvariables.puntos<100){MeshRenderer mesh= esfera.GetComponent<MeshRenderer>();
			mesh.material=material3;
			globalvariables.level=3;}

			if(globalvariables.puntos>=100&&globalvariables.puntos<200){MeshRenderer mesh= esfera.GetComponent<MeshRenderer>();
			mesh.material=material4;
			globalvariables.level=4;}

			if(globalvariables.puntos>=200){MeshRenderer mesh= esfera.GetComponent<MeshRenderer>();
			mesh.material=material5;
			globalvariables.level=5;}

			metodoavanzalevel();

		
	}
	void Update () {

		
			tiempoinicio+=Time.time;
			if(animaciontext.GetInteger("accion")==1){
			if(tiempoinicio>300){
				animaciontext.SetInteger("accion",0);
				//animaciontext2.SetInteger("accion",0);
						}
				}
			

			if(revisalevel==true){
				levelanterior=globalvariables.level;
				metodorevisa();}
		

		
		
		
		
		

		

		
		
	}
	public void metodoavanzalevel(){
				if(levelanterior<globalvariables.level){
				
				textlevel.text="LEVEL "+globalvariables.level;
				textlevel2.text="LEVEL "+globalvariables.level;
				tiempoinicio=-300;
				animaciontext.SetInteger("accion",1);
				//animaciontext2.SetInteger("accion",1);
				levelanterior=globalvariables.level;
				}


	}
}
