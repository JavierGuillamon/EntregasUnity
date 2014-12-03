using UnityEngine;
using System.Collections;

public class BajarAscensor : MonoBehaviour {
	//inicializamos las variables necesarias para el correcto funcionamiento del script serializando aquellas que consideramos oportuno
	private GameObject Player;
	[SerializeField]
	private GameObject ascensor;
	private Animation bajarAscensor;

	void Start () {//al iniciar el juego este metodo se ejecutara
		bajarAscensor = ascensor.GetComponent<Animation> ();//asigna el componente animation de ascensor a bajarAscensor
		Player = GameObject.Find ("Player") as GameObject;//busca en el juego un GameObject llamado Player
	}
	void OnTriggerExit(Collider otro )//al salir del trigger se ejecuta
	{
		bajarAscensor.Play("BajarAscensor");//inicia la animacion BajarAscensor
	}

}
