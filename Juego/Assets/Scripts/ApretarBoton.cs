using UnityEngine;
using System.Collections;

public class ApretarBoton : MonoBehaviour {
	//inicializamos las variables necesarias para el correcto funcionamiento del script serializando aquellas que consideramos oportuno
	private GameObject Player;

	[SerializeField]
	private GameObject boton;

	[SerializeField]
	private GameObject ascensor;

	private LlamarAscensor llamar;
	private Animation animacionBoton;
	private Animation subirAscensor;

	// Use this for initialization
	void Start () {//al iniciar el juego este metodo se ejecutara
		animacionBoton = boton.GetComponent<Animation> ();//asigna el componente animation de boton a animacionBoton
		llamar = ascensor.GetComponent<LlamarAscensor> ();//asigna el componente LlamarAscensor a llamar
		Player = GameObject.Find ("Player") as GameObject;//busca en el juego un GameObject llamado Player
	}

	void OnTriggerEnter(Collider otro)//al entrar en el trigger se ejecuta
	{
		animacionBoton.Play("apretarBoton");//inicia la animacion apretarboton

	}



}
