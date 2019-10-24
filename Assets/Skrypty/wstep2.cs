using UnityEngine;
using System.Collections;

public class wstep2 : MonoBehaviour {
	
	public Object obiekt_zniszcz;
	public float czas=Time.time;
	public float tik;
	public float niszcz;
	
	void Start(){
		
		gameObject.renderer.enabled = false;
		DestroyObject (obiekt_zniszcz, niszcz);
		
	}
	void Update () {
		
		if (czas < tik) {
			czas+=Time.deltaTime;
		}
		else {
			gameObject.renderer.enabled=true;
		}
	}
}

