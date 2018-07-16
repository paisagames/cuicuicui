using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaalienanave : MonoBehaviour {

	double tiempo;
	// Use this for initialization
	void Start () {
		tiempo=0;
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo=tiempo+Time.time;
		if(tiempo>120){
			transform.localPosition=new Vector3(1.85f,0.95f,1.191f);
			tiempo=0;

		}
		transform.Translate(0,0,2f);
		
	}
	
}
