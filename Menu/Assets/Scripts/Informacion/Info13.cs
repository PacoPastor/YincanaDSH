using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Info13 : MonoBehaviour {

		public Text texto;
		public int cont = 0;
		
		public void info()
		{
			if (cont == 0) {	
			texto.text = "Encuentra las salas de estudio ";
			cont = 1;
		} else{
			texto.text = "";
			cont = 0;
		}
			
	}
	}


