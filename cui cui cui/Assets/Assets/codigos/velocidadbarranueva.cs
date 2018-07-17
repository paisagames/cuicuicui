using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class velocidadbarranueva : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.localPosition= new Vector3(globalvariables.velocidad*(-1)*5f,transform.localPosition.y,transform.localPosition.z);
	}
	
		
}