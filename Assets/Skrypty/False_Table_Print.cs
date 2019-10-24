using UnityEngine;
using System.Collections;

public class False_Table_Print : MonoBehaviour {
	
	private bool checking=true;
	public bool pokaz=false;
	public bool juz_pokazalem;
	public Texture2D Tekstura;
	public AudioClip clip;
	private bool var_clip=true;
	
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

			
		}
	}
	
	void OnGUI(){
		
		if (pokaz == true) {
			GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 150, 30), "Press 'E' to read");
		}
		
		if (juz_pokazalem == true && checking==true) {
			Debug.Log("fsfs");
			GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura);
			PlayClip();
			StartCoroutine("Disap");
		}
		
	}
	void PlayClip()
	{
		if(var_clip)
		{
			audio.PlayOneShot(clip);
			var_clip=false;
		}
	}
	IEnumerator Disap()
	{
		yield return new WaitForSeconds(0.3f);
		juz_pokazalem = false;
		checking=false;
	}
	IEnumerator Wait()
	{
		yield return new WaitForSeconds(3f);
		juz_pokazalem = !juz_pokazalem;
		audio.Play ();	
	}
}