using UnityEngine;
using System.Collections;

public class Presents_1_view : MonoBehaviour {

	public Texture2D Tekstura;
	
	void OnGUI(){

		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Tekstura);
	}
}
