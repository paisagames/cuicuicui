using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tienda : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void compravida(){
		if(PlayerPrefs.HasKey("stars")){

			int strellas=PlayerPrefs.GetInt("stars");
			if(strellas>=10){

		if(PlayerPrefs.HasKey("vida")){  //f avanza.vida
			float vida=PlayerPrefs.GetFloat("vida");
			vida=vida+10f;
			PlayerPrefs.SetFloat("vida",vida);

		}else{
			PlayerPrefs.SetFloat("vida",10f);
				}
			
			strellas-=10;
			PlayerPrefs.SetInt("stars",strellas);
			}
		}
	}
	public void compraarmas(){
		if(PlayerPrefs.HasKey("stars")){

			int strellas=PlayerPrefs.GetInt("stars");
			if(strellas>=10){

		if(PlayerPrefs.HasKey("armo")){  //f avanza.vida
			float armo=PlayerPrefs.GetFloat("armo");
			armo=armo+1f;
			PlayerPrefs.SetFloat("armo",armo);

		}else{
			PlayerPrefs.SetFloat("armo",1f);
				}
			
			strellas-=10;
			PlayerPrefs.SetInt("stars",strellas);
			}
		}



	}//float

	public void compravelocidad(){
if(PlayerPrefs.HasKey("stars")){

			int strellas=PlayerPrefs.GetInt("stars");
			if(strellas>=10){

		if(PlayerPrefs.HasKey("velo")){  //f avanza.vida
			float vel=PlayerPrefs.GetFloat("velo");
			vel=vel+10f;
			PlayerPrefs.SetFloat("velo",vel);

		}else{
			PlayerPrefs.SetFloat("velo",10f);
				}
			
			strellas-=10;
			PlayerPrefs.SetInt("velo",strellas);
			}
		}



	}

}
