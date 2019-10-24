using UnityEngine;
using System.Collections;

public class Przelacznik : MonoBehaviour {

	public Object obiekt_zniszcz;
	public float czas=Time.time;
	public float next_czas=Time.time;

	void Start(){
		Screen.showCursor = false;
		gameObject.renderer.enabled = false;
		DestroyObject (obiekt_zniszcz, 5);

	}
	void Update () {

			if (czas < 5) {
			czas+=Time.deltaTime;
		}
			else {
				gameObject.renderer.enabled=true;
			}
		if (next_czas < 8.5f) {
			next_czas+=Time.deltaTime;}
		else {
			Application.LoadLevel (1);
		}

	}
}


		
