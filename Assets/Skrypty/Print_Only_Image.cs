using UnityEngine;
using System.Collections;

public class Print_Only_Image : MonoBehaviour {

	public Texture2D Tekstura;

	void Update(){
		StartCoroutine("WakeUp");
	}

	void OnGUI(){
		GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura);
		}
	IEnumerator WakeUp()
	{
		yield return new WaitForSeconds(9);
		Application.LoadLevel(5);
	}
}
