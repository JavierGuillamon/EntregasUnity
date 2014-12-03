using UnityEngine;
using System.Collections;

public class CogerLlave : MonoBehaviour {

	void OnTriggerEnter(Collider otro){//al entrar en el trigger se ejecuta
		if (otro.name == "Player") {//si el objeto que entra en el trigger es Player ejecuta el codigo
			otro.GetComponent<Inventario>().setLlave(true);//cambia el valor de llave a true
			Destroy(this.gameObject);//elimina el objeto
		}
	}
}
