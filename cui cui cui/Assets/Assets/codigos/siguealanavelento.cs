using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siguealanavelento : MonoBehaviour {

public Transform nave;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(nave);
		transform.Translate(0,0,0.05f);
	}
}
