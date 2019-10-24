using UnityEngine;
using System.Collections;

public class WEB_Countdown : MonoBehaviour {

	public static bool switcher=true;

	void Update () {
		if(Menu_View.web_check)
		{
			Func();
		}
	}

	void Func(){
		if(switcher)
		{
			switcher=false;
			DontDestroyOnLoad(gameObject);
			StartCoroutine("URL");
		}
	}
	IEnumerator URL()
	{
		yield return new WaitForSeconds(6);
		Application.OpenURL("www.orphan-game.tk");
	}
}
