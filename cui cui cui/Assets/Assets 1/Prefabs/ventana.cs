using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventana : MonoBehaviour {
	
	public Transform esto;
	float z;
	float x;
	// Use this for initialization
	void Start () {
		x = 1f;
		z = 1f;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.DownArrow)) {
			z++;
			esto.localPosition= new Vector3 (0, 0, z);}
		if (Input.GetKey (KeyCode.UpArrow)) {
			z--;
			esto.localPosition = new Vector3 (0, 0, z);}


		if (Input.GetKey (KeyCode.LeftArrow)) {
			x++;
			esto.localPosition = new Vector3 (x, 0, 0);}

		if (Input.GetKey (KeyCode.RightArrow)) {
			x--;
			esto.localPosition = new Vector3 (x, 0, 0);}
	}
}
