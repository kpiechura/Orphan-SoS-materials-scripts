using UnityEngine;
using System.Collections;

public class Chapter_Scrpit : MonoBehaviour {

	public Texture2D Tekstura;

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura); 
		StartCoroutine("Wait");
	}
	IEnumerator Wait()
	{
		yield return new WaitForSeconds(10);
		Application.LoadLevel("Level 1");
	}
}
