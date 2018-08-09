using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class ui : MonoBehaviour {

	

public AudioSource sonidomusica;
public AudioSource disparosonido;


public Image playimagenoriginal;
public Button plaubutton;
public Button pausebutton;

	public Image pausaimageoriginal;
	public Sprite imagenpausa;	
	public Sprite imagenplay;
	bool pausabool;
	

	public Button sonidobuton;
	public Image sonidoimage;
	public Text sonidotext;




	bool sonidob;
	double doubletiempo;
	bool booltiempo;


	public Image GObi;
	public Button GObb;
	public Text GObt;
	


	public Button menu2b;
	public Image menu2i;
	public Text menu2t;

	public static float velocidadguardada;
	// Use this for initialization
	void Start () {
		globalvariables.sonidoactivadobool=true;
		
		sonidob=true;
		pausabool=true;
		globalvariables.pausado=true;
	globalvariables.velocidadguardada=0;
	doubletiempo=0;
	booltiempo=false;
	startgame();

	}
	
	// Update is called once per frame
	void Update () {
		if(booltiempo==true){
			doubletiempo=doubletiempo+Time.time;
			if(doubletiempo>800){

				booltiempo=false;
				doubletiempo=0;
				//touchleft.enabled=false;
				//touchright.enabled=false;
			}
		}
		
	}
	public void startgame(){

//		fondiux.enabled=false;
		globalvariables.pausado=false;
		globalvariables.nbalas=30;
		//logo.enabled=false;
		pausaimageoriginal.enabled=true;
		pausabool=true;
		globalvariables.velocidad=0.7f;
		globalvariables.gameOn=true;
//		startbuton.enabled=false;
//		startimage.enabled=false;
//		starttext.enabled=false;
		sonidobuton.enabled=false;
		sonidoimage.enabled=false;
		sonidotext.enabled=false;
		//instruccionesbuton.enabled=false;
		//instruccionesimagge.enabled=false;
		//instruccionestext.enabled=false;

		//touchleft.enabled=true;
		//touchright.enabled=true;
		booltiempo=true;
		


		
	}

	

	

	public void sonido(){
		if(sonidob==true){sonidob=false;sonidotext.text="Music OFF";
		
		sonidomusica.enabled=false;
		disparosonido.enabled=false;
		globalvariables.sonidoactivadobool=false;
		}else{sonidob=true;sonidotext.text="Music ON";
		sonidomusica.enabled=true;
		disparosonido.enabled=true;
		globalvariables.sonidoactivadobool=true;
		}

	}
	public void reiniciar(){
		SceneManager.LoadScene("escena1");
		pausabool=false;
		globalvariables.pausado=false;
		globalvariables.nbalas=30;
	
		avanza.vida=100f;
		if(PlayerPrefs.HasKey("vida")){
			avanza.vida+=PlayerPrefs.GetFloat("vida");
		}
		

		//imagenvida.rectTransform.sizeDelta = new Vector2(avanza.vida, 100f);
		globalvariables.shooteralien=false;
		
		muerealien.restartbool=true;

		globalvariables.puntos=0;
		GObb.enabled=false;
		GObi.enabled=false;
		GObt.enabled=false;
	

		globalvariables.velocidad=0.2f;
	
		sonidobuton.enabled=false;
		sonidoimage.enabled=false;
		sonidotext.enabled=false;
		pausebutton.enabled=true;
		pausaimageoriginal.enabled=true;
		playimagenoriginal.enabled=false;
		plaubutton.enabled=false;
	
		booltiempo=true;
	}
	public void menup(){
		SceneManager.LoadScene("escena1");
	}

public void playm(){



		GObb.enabled=false;
		GObi.enabled=false;
		GObt.enabled=false;
		sonidobuton.enabled=false;
		sonidoimage.enabled=false;
		sonidotext.enabled=false;
	
		pausabool=false;
		globalvariables.velocidad=globalvariables.velocidadguardada;
		
		pausebutton.enabled=true;
		pausaimageoriginal.enabled=true;
		playimagenoriginal.enabled=false;
		plaubutton.enabled=false;

		menu2b.enabled=false;
		menu2i.enabled=false;
		menu2t.enabled=false;
		globalvariables.pausado=false;


	//no se que hice que se quito los disparos pero sigue la musica



}
	public void pausa(){
		
		
		GObb.enabled=true;
		GObi.enabled=true;
		GObt.enabled=true;
		sonidobuton.enabled=true;
		sonidoimage.enabled=true;
		sonidotext.enabled=true;
		//instruccionesbuton.enabled=true;
		//instruccionesimagge.enabled=true;
		//instruccionestext.enabled=true;
		pausabool=true;
		menu2b.enabled=true;
		menu2i.enabled=true;
		menu2t.enabled=true;
		
		pausaimageoriginal.enabled=false;
		playimagenoriginal.enabled=true;
		plaubutton.enabled=true;
		pausebutton.enabled=false;
		globalvariables.velocidadguardada=globalvariables.velocidad;
		globalvariables.velocidad=0;
		globalvariables.pausado=true;


		
		

		


	}

}
