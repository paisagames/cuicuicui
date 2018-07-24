using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alrevez : MonoBehaviour {
public Text textbase;
public Text thistext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		thistext.rectTransform.position=new Vector3(thistext.rectTransform.position.x,textbase.rectTransform.position.y*(-14.0f),textbase.rectTransform.position.z);
			//estaba en -5.7	
	}
}
