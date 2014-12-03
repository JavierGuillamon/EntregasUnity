using UnityEngine;
using System.Collections;

public class TeletransporteVuelta : MonoBehaviour {
	//ceamos el GameObject Player
	private GameObject Player;
	
	
	
	void Start () {//al iniciarse el juego se busca un GameObjectr llamado Player y se le asigna a nuestro GameObject Player
		Player = GameObject.Find ("Player") as GameObject;
	}
	
	void OnTriggerEnter(Collider otro)//al entrar en el trigger se ejecuta
	{
		if (otro.name == "Player") {//si el objeto que entra es Player se realiza una transformacion de sus cordenadas para transportarle a otro lugar
			//en este caso sumamos lo mismo que restamos en el script Teletransporte para volver al mismo lugar 
			float x = Player.transform.position.x + (float)5;
			float y = Player.transform.position.y + (float)3;
			float z = Player.transform.position.z + (float)15;
			Player.transform.position = new Vector3(x, y, z);
		}
	}
}
	

