using UnityEngine;
using System.Collections;

public class BajarAscensor : MonoBehaviour {
	[SerializeField]
	private GameObject ascensor;
	private Animation	bajarAscensor;
	// Use this for initialization
	void Start () {//al inicar el juego se iguala el valor de subirAscensor al componente Animation de ascensor
		bajarAscensor = ascensor.GetComponent<Animation> ();
	}
	
	public void LlamarBajar(){//metodo Llamar que ejecuta la animacion SubirAscensor
		bajarAscensor.Play("BajarAscensor");
	}


}
