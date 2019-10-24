using UnityEngine;
using System.Collections;

public class Extras_View : MonoBehaviour {

	public Texture2D Tekstura;
	void Start(){
		StartCoroutine("URL");
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura); 

		if (Input.anyKeyDown)
			Application.LoadLevel (2);
		
	}
	IEnumerator URL()
	{
		yield return new WaitForSeconds(3);
		Application.OpenURL("www.orphan-dev.tk");
	}
}
