using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copiarotacion : MonoBehaviour {

	public Transform nave;
	// Use this for initialization
	void Start () {
		transform.rotation=nave.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation=nave.rotation;
		
	}
}
