using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class canvascode2 : MonoBehaviour {
//public RectTransform canvass;
	public Image imagenTIENDA;

	public Image imagenTITULO;
	public Image imagenayuda2;

	Vector3 posicionTIENDA;
	Vector3 posicionTITULO;

	Vector3 posicionREGRESA;
	//float canvas_X;
	//float canvas_Y;
	// Use this for initialization
	void Start () {
		//canvas_X = canvass.sizeDelta.x;
		//canvas_Y = canvass.sizeDelta.y;
		posicionTITULO=imagenTITULO.rectTransform.position;
		posicionTIENDA=imagenTIENDA.rectTransform.position;
		posicionREGRESA=imagenayuda2.rectTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//canvas_X = canvass.sizeDelta.x;
		//canvas_Y = canvass.sizeDelta.y;

		//imagenTIENDA.rectTransform.localScale=new Vector3(canvas_X/100,canvas_Y/100,0);
		//imagenbase.rectTransform.position = new Vector3 (0, 0, 0);

		
	}
	public void tienda(){

		//imagenTITULO.rectTransform.position=posicionTIENDA;
		imagenTIENDA.rectTransform.position=posicionTITULO;
	}

	public void quitatienda(){
		imagenTIENDA.rectTransform.position=posicionREGRESA;
	}

	//poner la imagen base
	//poner la imagen ganado

	/*
KEYSTORE:
c:/9 semestre/Rolling 15/Rolling.keystore

	*/
}