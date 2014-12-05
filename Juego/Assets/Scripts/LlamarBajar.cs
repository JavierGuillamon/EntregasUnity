using UnityEngine;
using System.Collections;

public class LlamarBajar : MonoBehaviour {

	//creamos las variables y serializamos ascensor
	[SerializeField]
	private GameObject ascensor;
	private BajarAscensor bajar;
	// Use this for initialization
	void Start () {//al iniciar el juego se iguala llamar al componente LlamarAscensor de ascensor
		bajar = ascensor.GetComponent<BajarAscensor> ();
	}
	
	public void Mandar(){//metodo Mandar que ejecuta el metodo Llamar() del objetp llamar
		bajar.LlamarBajar();
	}
}
