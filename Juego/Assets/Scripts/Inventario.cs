using UnityEngine;
using System.Collections;

public class Inventario : MonoBehaviour {

	private bool boolLlave;//variable boolean boolLlave


	void Start () {//al iniciar el juego se establece que boolLlave es falso
		boolLlave = false;
	}
	
	public bool getLlave(){//metodo para coger el valor de boolLlave
		return boolLlave;
	}
	public void setLlave(bool a){//metodo para cambiar el valor de boolLlave
		boolLlave = a;
	}


}
