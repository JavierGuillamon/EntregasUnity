using UnityEngine;
using System.Collections;

public class Teletransporte : MonoBehaviour {
	//ceamos el GameObject Player
	private GameObject Player;
	
	
	
	void Start () {//al iniciarse el juego se busca un GameObjectr llamado Player y se le asigna a nuestro GameObject Player
		Player = GameObject.Find ("Player") as GameObject;
	}
	
	void OnTriggerEnter(Collider otro)//al entrar en el trigger se ejecuta
	{
		if (otro.name == "Player") {	//si el objeto que entra es Player se realiza una transformacion de sus cordenadas para transportarle a otro lugar
			//cogemos la posicion actual de Player y la alteramos para moverlo a donde queremos
			float x = Player.transform.position.x - (float)5;
			float y = Player.transform.position.y - (float)3;
			float z = Player.transform.position.z - (float)15;
			Player.transform.position = new Vector3(x, y, z);
			//son 5, 3 y 15 unidades pues es la diferencia de distancia que hay entre la zona que atraviesa en una primera instancia el jugador, y la zona a la que queremos llevarle
		}
	}
}
