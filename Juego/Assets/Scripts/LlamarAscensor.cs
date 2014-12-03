using UnityEngine;
using System.Collections;

public class LlamarAscensor : MonoBehaviour {
	//inicializamos las variables y serializamos ascensor

	[SerializeField]
	private GameObject ascensor;
	private Animation subirAscensor;
	// Use this for initialization
	void Start () {//al inicar el juego se iguala el valor de subirAscensor al componente Animation de ascensor
		subirAscensor = ascensor.GetComponent<Animation> ();
	}

	public void Llamar(){//metodo Llamar que ejecuta la animacion SubirAscensor
		subirAscensor.Play("SubirAscensor");
	}

}
