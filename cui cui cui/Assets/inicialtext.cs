using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class inicialtext : MonoBehaviour {
	public Text texto;
	// Use this for initialization
	StreamReader streampolitica=new StreamReader("Assets/Privacy_Policy.txt");
	void Start () {
		string line=streampolitica.ReadToEnd();
		texto.text=""+line;
		streampolitica.Close();
		
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
