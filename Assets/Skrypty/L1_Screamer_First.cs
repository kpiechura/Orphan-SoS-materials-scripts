using UnityEngine;
using System.Collections;

public class L1_Screamer_First : MonoBehaviour {
	
	public Texture2D Tex;
	public AudioClip clip;
	public GameObject[] obj=new GameObject[4]; 
	
	private bool turn=true;	
	private bool pokaz=false;
	
	void OnTriggerEnter(Collider other){
		if(turn)
		{
			if (other.tag == "Player") {
				EnableFalse();
				pokaz = true;
				audio.Play ();
			}
		}
	}
	
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			pokaz = false;
			turn=false;
		}
	}
	
	void OnGUI(){
		if (pokaz== true) {
			GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tex);
			turn=false;
			StartCoroutine("waitAndHide");
		}
	}
	
	IEnumerator waitAndHide()
	{
		yield return new WaitForSeconds(0.4f);
		pokaz = false;
	}  
	
	void EnableFalse()
	{
		for(int i=0; i<4; ++i)
		{
			obj[i].gameObject.renderer.enabled=false;
		}
	}
}
