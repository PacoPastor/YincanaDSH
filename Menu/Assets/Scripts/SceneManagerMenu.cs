using UnityEngine;
using System.Collections;

public class SceneManagerMenu : MonoBehaviour {

	public void comenzar()
	{
		Application.LoadLevel ("PantallaNivel1");
	}

	public void ayuda()
	{
		Application.LoadLevel ("Ayuda1");
	}

	public void esi()
	{
		Application.OpenURL ("http://esingenieria.uca.es/");
	}

	public void creditos()
	{
		Application.LoadLevel ("Creditos");
	}

	public void salir()
	{
		Application.Quit ();
	}
}
