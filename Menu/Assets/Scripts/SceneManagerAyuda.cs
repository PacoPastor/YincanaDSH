using UnityEngine;
using System.Collections;

public class SceneManagerAyuda : MonoBehaviour {


	public void retroceder1()
	{
		Application.LoadLevel("menuanimado");
	}

	public void avanzar1()
	{
		Application.LoadLevel ("Ayuda2");
	}

	public void retroceder2()
	{
		Application.LoadLevel ("Ayuda1");
	}

}
