using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Info4 : MonoBehaviour {

		public Text texto;
		public int cont = 0;
		
		public void info()
		{
			if (cont == 0) {	
			texto.text = "Encuentra la conserjería";
			cont = 1;
		} else{
			texto.text = "";
			cont = 0;
		}
			
	}
	}


