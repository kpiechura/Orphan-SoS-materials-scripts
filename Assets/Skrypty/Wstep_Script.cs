using UnityEngine;
using System.Collections;

public class Wstep_Script : MonoBehaviour {

	public Texture2D Tekstura;
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura); 
		GUI.Label(new Rect(0,0,Screen.width, Screen.height), "Kamil Piechura");
	}

	void Update () {
	
	}
}
