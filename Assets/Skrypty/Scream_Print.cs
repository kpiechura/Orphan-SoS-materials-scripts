using UnityEngine;
using System.Collections;

public class Scream_Print : MonoBehaviour {

	private bool turn=true;	
	public Texture2D Tekstura;
	private bool pokaz=false;
	public float zmienna;
	
	void OnTriggerEnter(Collider gameObject){
		if(turn)
		{
			if (gameObject.tag == "Player") {
				pokaz = true;
				audio.Play ();
			}
		}
	}
	
	void OnTriggerExit(Collider gameObject){
		if (gameObject.tag == "Player") {
			pokaz = false;
			turn=false;
			Destroy(gameObject);
		}
	}
	
	void OnGUI(){
		if (pokaz== true) {
			GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura);
			StartCoroutine("waitAndHide");
		}
	}
	
	IEnumerator waitAndHide()
	{
		yield return new WaitForSeconds(zmienna);
		pokaz = false;
	}  
}