using UnityEngine;
using System.Collections;

public class AbrirPuertaSecreta : MonoBehaviour {

	private GameObject Player;//creamos un GameObject y lo llamamos Player

	[SerializeField]//Serializa el objeto creado a continuacion, asi podemos acceder a este camopo desde el entorno de Unity 
	private GameObject puerta;//creamos un GameObject y lo Puerta

	private Animation animacionPuerta;//Animacion llamada animacionPuerta
	// Use this for initialization
	void Start () {//al iniciar el juego se ejecutara lo siguiente
		animacionPuerta = puerta.GetComponent<Animation> ();//se le asigna a animacionPuerta un componente Animation sacado del objeto puerta
		Player = GameObject.Find ("Player") as GameObject;//busca en el juego un GameObject llamado Player
	}
	
	void OnTriggerEnter(Collider otro)//metodo que se ejecuta al entrar en el triguer
	{
		animacionPuerta.Play("AbrirPuerta");//inicia la animacion AbrirPuerta
	}

	void OnTriggerExit(Collider otro )//metodo que se ejecuta al salir del triguer
	{
		animacionPuerta.Play("cerrarPuerta");//inicia la animacion cerrarPuerta
	}

	
}
