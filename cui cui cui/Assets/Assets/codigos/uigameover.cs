using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class uigameover : MonoBehaviour {
	public Text now;
	public Text total;

	// Use this for initialization
	void Start () {
		now.text="NOW "+globalvariables.puntos;
		int toal=PlayerPrefs.GetInt("stars");
		total.text="TOTAL "+toal;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
