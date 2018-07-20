using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI19 : MonoBehaviour {
	public Image velocidadbola;
	public Text text;
	public Image v1;
	public Image v2;
	public Image v3;
	public Image v4;
	public Image v5;
	public Image v6;
	public Image v7;
	public Image v8;
	public Image v9;
	public Image v10;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(avanza.vida>=100f){v10.enabled=true;}else{v10.enabled=false;}
		if(avanza.vida>=90f){v9.enabled=true;}else{v9.enabled=false;}
		if(avanza.vida>=80f){v8.enabled=true;}else{v8.enabled=false;}
		if(avanza.vida>=70f){v7.enabled=true;}else{v7.enabled=false;}
		if(avanza.vida>=60f){v6.enabled=true;}else{v6.enabled=false;}
		if(avanza.vida>=50f){v5.enabled=true;}else{v5.enabled=false;}
		if(avanza.vida>=40f){v4.enabled=true;}else{v4.enabled=false;}
		if(avanza.vida>=30f){v3.enabled=true;}else{v3.enabled=false;}
		if(avanza.vida>=20f){v2.enabled=true;}else{v2.enabled=false;}
		if(avanza.vida>=10f){v1.enabled=true;}else{v1.enabled=false;}
		if(globalvariables.velocidad<2.5f){
		velocidadbola.rectTransform.sizeDelta=new Vector2(globalvariables.velocidad*300f,globalvariables.velocidad*300f);
		}
		velocidadbola.transform.Rotate(0,0,1.5f);
//		text.text="v:"+globalvariables.velocidad;

		//ajustar bien el tamaño de la velocidad para que el circulo no parpadee
		
		
		
	}
}
