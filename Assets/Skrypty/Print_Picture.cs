using UnityEngine;
using System.Collections;

public class Print_Picture : MonoBehaviour {
	
	public bool pokaz=false;
	public bool juz_pokazalem;
	public Texture2D Tekstura;
	
	
	void OnTriggerEnter(Collider gameObject){
		
		if (gameObject.tag == "Player") {
			pokaz = true;
		}
	}
	
	void OnTriggerExit(Collider gameObject){
		
		if (gameObject.tag == "Player") {
			pokaz = false;
			juz_pokazalem = false;
		}
	}
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.E) && pokaz==true) {
			juz_pokazalem = !juz_pokazalem;
			audio.Play ();
		}
	}
	
	void OnGUI(){
		
		if (pokaz == true) {
			GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 150, 30), "Press 'E' to read");
		}
		
		if (juz_pokazalem == true) {
			GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura);
		}
		
	}
}