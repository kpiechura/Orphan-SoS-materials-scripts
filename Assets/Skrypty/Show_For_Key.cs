using UnityEngine;
using System.Collections;

public class Show_For_Key : MonoBehaviour {

	public bool pokaz=false;
	public bool juz_pokazalem;
	public bool klucz_des=false;
	public static bool otworz = false;
	public static bool forif=false;
	public AudioSource source;

	public GameObject klucz;

	void OnTriggerEnter(Collider gameObject){
		
		if (gameObject.tag == "Player") {
			pokaz = true;
			forif=true;
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
			Destroy(klucz);
			klucz_des=true;
			source.audio.Play ();
			otworz=true;
		}
	}
	void OnGUI(){
		
		if (pokaz == true && klucz_des!=true) {
			GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 150, 30), "Press 'E' to get the key");
		}
		
	}
}
