using UnityEngine;
using System.Collections;

public class Chapter4_SCR : MonoBehaviour {
	
	public Texture2D Tekstura;
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura); 
		StartCoroutine("Wait");
	}
	IEnumerator Wait()
	{
		yield return new WaitForSeconds(10);
		Application.LoadLevel("Level4");
	}
}
