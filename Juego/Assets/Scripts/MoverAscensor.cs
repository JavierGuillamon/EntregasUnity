﻿using UnityEngine;
using System.Collections;

public class MoverAscensor : MonoBehaviour {
	//creamos las variables y serializamos ascensor
	[SerializeField]
	private GameObject ascensor;
	private LlamarAscensor llamarSubir;
	// Use this for initialization
	void Start () {//al iniciar el juego se iguala llamar al componente LlamarAscensor de ascensor
		llamarSubir = ascensor.GetComponent<LlamarAscensor> ();
	}

	public void Mandar(){//metodo Mandar que ejecuta el metodo Llamar() del objetp llamar
		llamarSubir.Llamar ();
	}

}
