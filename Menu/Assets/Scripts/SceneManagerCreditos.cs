using UnityEngine;
using System.Collections;

public class SceneManagerCreditos : MonoBehaviour {

	public void retroceder()
	{
		Application.LoadLevel ("menuanimado");
	}

	public void github()
	{
		Application.OpenURL ("https://github.com/SephiRx11/YincanaDSH");
	}
}
