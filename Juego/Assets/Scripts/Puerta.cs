using UnityEngine;
using System.Collections;

public class Puerta : MonoBehaviour {
	//inicializamos las variables necesarias para el correcto funcionamiento del script serializando aquellas que consideramos oportuno
	private GameObject Player;
	private Inventario inventario;
	[SerializeField]
	private GameObject puerta;
	private Animation animacionPuerta;


	// Use this for initialization
	void Start () {//al iniciar el juego se le asignan valores a animacioPuerta y Player
		animacionPuerta = puerta.GetComponent<Animation> ();
		Player = GameObject.Find ("Player") as GameObject;
	}
	
	void OnTriggerEnter(Collider otro)//al entrar en el trigger se ejecuta el siguiente codigo
	{
		if (otro.name == "Player" && Player.GetComponent<Inventario>().getLlave()) {//si el objeto que entra es Player y este tiene dentro de su inventario la llave se ejecuta la animacion AbrirPuerte
			animacionPuerta.Play("AbrirPuerta");

		}
	}
	void OnTriggerExit(Collider otro )//al salir en el trigger se ejecuta el siguiente codigo
	{
		if (otro.name == "Player" && Player.GetComponent<Inventario>().getLlave()) {//si el objeto que entra es Player y este tiene dentro de su inventario la llave se ejecuta la animacion cerrarPuerta
			animacionPuerta.Play("cerrarPuerta");
		
		}
	}
}
