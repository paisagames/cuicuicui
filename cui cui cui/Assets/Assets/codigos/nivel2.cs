using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nivel2 : MonoBehaviour {
public MeshRenderer skyrender;
public Material material2;
public Transform esfera;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(globalvariables.puntos>=20){
			MeshRenderer mesh= esfera.GetComponent<MeshRenderer>();
			mesh.material=material2;
			mesh.materials[0]=material2;
			mesh.materials[1]=material2;
		}
		if(Input.GetKeyDown(KeyCode.N)){
			globalvariables.puntos++;
		}

		
		
	}
}
