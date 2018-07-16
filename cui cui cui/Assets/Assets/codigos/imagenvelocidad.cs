using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imagenvelocidad : MonoBehaviour {
	public Image imagen;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		imagen.rectTransform.sizeDelta=new Vector2(imagen.rectTransform.sizeDelta.x,globalvariables.velocidad*500);
		
	}
}
