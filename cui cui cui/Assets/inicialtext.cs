using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class inicialtext : MonoBehaviour {
	public Text texto;
	public TextAsset TEXTOO;
	
	// Use this for initialization
	
	void Start () {
		string line2=TEXTOO.ToString();
		
		
		texto.text=""+line2;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void agree(){
		PlayerPrefs.SetString("Iniciaintro","FALSE");
		SceneManager.LoadScene("historia");
	}
	public void disagree(){
		PlayerPrefs.SetString("Iniciaintro","FALSEPOLI");
		Application.Quit();
	}
}
