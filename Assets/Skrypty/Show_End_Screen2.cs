using UnityEngine;
using System.Collections;

public class Show_End_Screen2 : MonoBehaviour {
	
	public Texture2D Tekstura;
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura); 
		StartCoroutine("Wait");
	}
	IEnumerator Wait()
	{
		yield return new WaitForSeconds(13);
		Application.LoadLevel("Menu");
	}
}
