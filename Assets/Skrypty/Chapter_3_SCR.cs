using UnityEngine;
using System.Collections;

public class Chapter_3_SCR : MonoBehaviour {
	
	public Texture2D Tekstura;
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura); 
		StartCoroutine("Wait");
	}
	IEnumerator Wait()
	{
		yield return new WaitForSeconds(10);
		Application.LoadLevel("Level5");
	}
}
