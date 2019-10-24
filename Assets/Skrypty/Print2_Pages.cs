using UnityEngine;
using System.Collections;

public class Print2_Pages : MonoBehaviour {
	
	public Texture2D Tex1,Tex2;
	private bool show_card=false;
	private int print_cards;

	void Start(){
		print_cards=0;
	}

	void OnTriggerEnter(Collider other){
		
		if (other.tag == "Player") {
			show_card = true;	
		}
	}
	
	void OnTriggerExit(Collider other){
		
		if (other.tag == "Player") {
			show_card = false;
		}
	}
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.E) && show_card) {
			++print_cards;
			audio.Play ();
		}
		if(print_cards==3)
			print_cards=0;
	}
	
	void OnGUI(){
		
		if (show_card == true) {
			GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 150, 30), "Press 'E' to read");
		}
		
		if (print_cards==1) {
			GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tex1);
		}
		if (print_cards==2) {
			GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tex2);
		}

	}
}