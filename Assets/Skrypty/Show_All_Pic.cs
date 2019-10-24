using UnityEngine;
using System.Collections;

public class Show_All_Pic : MonoBehaviour {
	
	private bool pok=false;
	private bool hide=false;

	public static bool next=false;
	public Texture2D[] Tex = new Texture2D[5]; 

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			pok=true;
		}
	}
	void OnGUI(){
		if(pok)
		{
			for (int i=0; i<5; ++i)
			{
				if(hide==false){
					audio.Play ();
					GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tex[i]);
					StartCoroutine("WaitAndHide");
					StartCoroutine("ForTex1");
				}
			}

		}
			
	}
	IEnumerator ForTex1(){
		yield return new WaitForSeconds(0.5f);
		hide=false;
	}
	IEnumerator WaitAndHide(){
		yield return new WaitForSeconds(0.3f);
		hide=true;
	}
}

