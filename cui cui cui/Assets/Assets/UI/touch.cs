using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touch : MonoBehaviour {
	
	public Image imagenboton;
	public Image imagenbotonPOSBASE;
	//iphone pantalla
	//1242px  x 2208px


	//ipad pantalla
	//2048px x 2732px
	string direccionanterior;
	public Transform xminT;
	public Transform xmaxT;
	public Transform yminT;
	public Transform ymaxT;


	public RectTransform canvas;
	

	public Transform principal;
	//public Transform central;

	Touch toucch= new Touch();
	float x;
	float y;
	float newX;
	float newY;
	float tamañopantalla_X;
	float tamañopantalla_Y;
	float cbx;
	float cby;
	
	bool touchunavez;


	bool tocando;
	Vector2 touch2;
	float valorinicial;
	Vector2 posicionInicialControladorTouch;

	// Use this for initialization
	public void Start () {
		direccionanterior="0";
		valorinicial=0.05f;//0.03f
		tocando=false;
		//principal.position = new Vector3 (1.53f, 4.22f, -0.448f);
		x = 0;
		y = 0;
		newX = 0;
		newY = 0;
		touchunavez=true;
		touch2= new Vector2(0,0);
		
		posicionInicialControladorTouch= new Vector2(imagenboton.rectTransform.position.x,imagenboton.rectTransform.position.y);

		//	textovalores.text="posinicialtouch:"+imagenboton.rectTransform.position.x+","+imagenboton.rectTransform.position.y;

	}


	//1242px - 5.654x
	//2208px- 10.074y


	//2048 TOUCH X:1032.192 Y:1363.852 ESQUIVALEN A 0,0 EN POSICION NORMAL EN IPAD
	//1242 TOUCH X:604.44 Y:1143.72 EQUIVALEN A 0,0 EN POSICION NORMAL EN IPHONE
	// Update is called once per frame
	void Update () {

		float sx=0f;
		float sy=0f;
		tamañopantalla_X = canvas.sizeDelta.x;//alrevez
		tamañopantalla_Y = canvas.sizeDelta.y;//alrevez
	

		


		//cubofondo.localScale = new Vector3 (cbx, cby, 2f);


		

		

		if (Input.touchCount > 0) {// && Input.GetTouch(0).phase == TouchPhase.Moved)
			// Get movement of the finger since last frame
			Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;
		
			
			 touch2 = Input.GetTouch (0).position;
			 
			//X: va de 0 -> MAX de izquierda a derecha
			//Y:va de 0 -> MAX de abajo hacia arriba

			//-2.5 y 2.5 en X son los maximos y minimos dentro de la camara
			//-1.5 y 1.5 son los max y min dentro de la camara

			float maxUIx=tamañopantalla_X;
			float minUIx=tamañopantalla_X*(-1f);

			float maxUIy=tamañopantalla_Y;
			float minUIy=tamañopantalla_Y*(-1);


			float Nx=tamañopantalla_X/2f;
			float NxMITAD=touch2.x-Nx;


			
			float Ny=tamañopantalla_Y/2f;
			float NyMitad=touch2.y-Ny;

			float misteriox=2.5f/Nx;
			float misterioy=1.3f/Ny;


			float posicionEnlaqueDebeestarX=(touch2.x-Nx)*misteriox;
			float posicionEnlaqueDebeestarY=(touch2.y-Ny)*misterioy;
			



			//YA TENGO LAS POSICIONES DONDE DEBERIA ESTAR AL TOCAR LA PANTALLA
			//EL PEDO ES COMO HAGO QUE SE MUEVA HACIA ESAS POSICIONES
			//LO DE ABAJO A ESTE COMENTARIO ES BASURA

			//restarle la mitad del tamaño de la pantalla y multiplicarlo por un numero que su maximo de 2.5 y minimo -2.5


			float ix=imagenboton.rectTransform.position.x;
			float iy=imagenboton.rectTransform.position.y;
			x = touch2.x;
			y = touch2.y;

			
			//textovalores.text="x:"+x+", y:"+y+"nmitad"+NxMITAD+",posdebeY:"+posicionEnlaqueDebeestarY+"IB:"+ix+","+iy;

			//CANVAS SIZE ES LO MISMO QUE EL MAX DE PANTALLA

			if(tocando==true){
				imagenboton.rectTransform.position=new Vector2(touch2.x,touch2.y);
			}else{imagenboton.rectTransform.position=imagenbotonPOSBASE.rectTransform.position;
			
			//textovalores.text="posinicialtouch:"+imagenboton.rectTransform.position.x+","+imagenboton.rectTransform.position.y;

			}
			float actualX=imagenboton.rectTransform.position.x;
			float actualY=imagenboton.rectTransform.position.y;

			float centroX=imagenbotonPOSBASE.rectTransform.position.x;
			float centroY=imagenbotonPOSBASE.rectTransform.position.y;

			string direccion="0";
			float margenEspacio=2f;
			if(tocando==true){
			if(actualX<centroX-margenEspacio){
				if(actualY<centroY-margenEspacio){direccion="izqabajo";}else{
					if(actualY>centroY+margenEspacio){direccion="izqarriba";}else{
						direccion="izqcentro";}
				}

			}else{
				if(actualX>centroX+margenEspacio){
					if(actualY<centroY-margenEspacio){direccion="derabajo";}else{
						if(actualY>centroY+margenEspacio){direccion="derarriba";}else{
							direccion="dercentro";
						}
					}
				}
				else{
					if(actualY<centroY-margenEspacio){direccion="abajocentro";}else{
						if(actualY>centroY+margenEspacio){direccion="arribacentro";}else{
							direccion="0";
						}
					}
				}



			}//terminan los if else

			bool xmovemas=false;bool ymovemas=false;bool xmovemenos=false;bool ymovemenos=false;
			if(principal.localPosition.x<xmaxT.localPosition.x){xmovemas=true;};
			if(principal.localPosition.x>xminT.localPosition.x){xmovemenos=true;};
			if(principal.localPosition.y<ymaxT.localPosition.y){ymovemas=true;};
			if(principal.localPosition.y>yminT.localPosition.y){ymovemenos=true;};
			
			float superx=valorinicial;
			float supery=valorinicial;

			
			switch(direccion){
				case "izqabajo":if(direccionanterior!="izqabajo"){ direccionanterior="izqabajo";reiniciainicial();};
				if(xmovemenos==true){superx=(-1f)*valorinicial;}else{superx=0;}
				;if(ymovemenos==true){supery=(-1f)*valorinicial;}else{supery=0;}
				;break;
				
			
				case "izqarriba":if(direccionanterior!="izqarriba"){ direccionanterior="izqarriba";reiniciainicial();};
				if(xmovemenos==true){superx=(-1f)*valorinicial;}else{superx=0;}
				;
				if(ymovemas==true){supery=valorinicial;}else{supery=0;}
				;break;

				case "izqcentro":if(direccionanterior!="izqcentro"){ direccionanterior="izqcentro";reiniciainicial();};
				if(xmovemenos==true){superx=(-1f)*valorinicial;supery=0;}else{superx=0;supery=0;}
				
				;break;
				case "derabajo":if(direccionanterior!="derabajo"){ direccionanterior="derabajo";reiniciainicial();};
				if(xmovemas==true){superx=valorinicial;}else{superx=0;}
				;if(ymovemenos==true){supery=(-1f)*valorinicial;}else{supery=0;}
				;break;


				case "derarriba":if(direccionanterior!="derarriba"){ direccionanterior="derarriba";reiniciainicial();};
				if(xmovemas==true){superx=valorinicial;}else{superx=0;}
				;if(ymovemas==true){supery=valorinicial;}else{supery=0;}
				;break;

				case "dercentro":if(direccionanterior!="dercentro"){ direccionanterior="dercentro";reiniciainicial();};
				if(xmovemas==true){superx=valorinicial;supery=0;}
				else{supery=0;superx=0;}
				;break;

				case "abajocentro":if(direccionanterior!="abajocentro"){ direccionanterior="abajocentro";reiniciainicial();};
				if(ymovemenos==true){supery=(-1f)*valorinicial;superx=0;}
				;break;

				case "arribacentro":if(direccionanterior!="arribacentro"){ direccionanterior="arribacentro";reiniciainicial();};
				if(ymovemas==true){supery=valorinicial;superx=0;}
				;break;
				case "0":superx=0;supery=0;break;

			}
			//superx*=2f;
			//supery*=2f;
			//if(superx>0||superx<0){superx*=1.1f;}
			//if(supery>0||supery<0){supery*=1.1f;}
			principal.transform.Translate(superx,supery,0);
			sx=superx;
			sy=supery;
			
			//if(valorinicial<0.01f){
			//valorinicial+=0.002f;
			//}


			}//tocando true
			





		}//Cierra touch
		//textovalores.text="sx:"+sx+",sy:"+sy+",vi:"+valorinicial;
	}//cierra update

public void botontouchtrue(){
	tocando=true;
	
}
public void botontouchfalse(){
	tocando=false;
	
	
}
void reiniciainicial(){
	//valorinicial=0;
}

}
