using UnityEngine;
using System.Collections;

public class Presents_View : MonoBehaviour {

	public Texture2D Tekstura;
	public Texture2D Tekstura1;
	public float czas=Time.time;

	void Start(){

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Tekstura);
	}

	void Update(){

		if (czas < 5) {
			czas+=Time.deltaTime;}
		else {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Tekstura1);
		}
	}	
}

