using UnityEngine;
using System.Collections;

public class Show_End_Screens : MonoBehaviour {
	
	public Texture2D Tekstura;
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura); 
		StartCoroutine("Wait");
	}
	IEnumerator Wait()
	{
		yield return new WaitForSeconds(9.5f);
		Application.LoadLevel("END_2");
	}
}
