using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nivel2 : MonoBehaviour {
	public Text textlevel;
public MeshRenderer skyrender;
public Material material2;

public Material material3;

public Material material4;

public Material material5;
public Transform esfera;
public Animator animaciontext;
double tiempoinicio;
Vector2 posicionlevel;
bool met;
	// Use this for initialization
	void Start () {
		met=false;
		tiempoinicio=0;
		globalvariables.level=1;
		posicionlevel=textlevel.transform.position;
		animaciontext.SetInteger("accion",1);
		
	}
	
	// Update is called once per frame
	void Update () {
			tiempoinicio+=Time.time;
			if(animaciontext.GetInteger("accion")==1){
			if(tiempoinicio>300){
				animaciontext.SetInteger("accion",0);

			}
			}
		

		switch(globalvariables.puntos){
			case 20: if(met==false){metodoavanzalevel();met=true;};
			MeshRenderer mesh= esfera.GetComponent<MeshRenderer>();
			mesh.material=material2;
			break;
			case 21: met=false;break;
			case 50: if(met==false){metodoavanzalevel();met=true;
			MeshRenderer mesh2= esfera.GetComponent<MeshRenderer>();
			mesh2.material=material3;
			};break;
			case 51:met=false;break;
			case 100:if(met==false){metodoavanzalevel();met=true;
			MeshRenderer mesh3= esfera.GetComponent<MeshRenderer>();
			mesh3.material=material4;
			}; break;
			case 101: met=false;break;
			case 200:if(met==false){metodoavanzalevel();met=true;
			MeshRenderer mesh4= esfera.GetComponent<MeshRenderer>();
			mesh4.material=material2;
			
			}; break;
			case 201: met=false;break;
			
		}
		
		
		
		

		

		
		
	}
	public void metodoavanzalevel(){
				globalvariables.level++;
				textlevel.text="LEVEL "+globalvariables.level;
				tiempoinicio=-300;
				animaciontext.SetInteger("accion",1);
			


	}
}
