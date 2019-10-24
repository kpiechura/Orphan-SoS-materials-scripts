using UnityEngine;
using System.Collections;

public class Dead_Screen_Script : MonoBehaviour {

	public Texture2D Tekstura;

	void Start(){
		Screen.showCursor = true;
	}

	void OnGUI(){
		GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura);
		AutoResize(1920, 1080);

		if (GUI.Button (new Rect (930, 700, 200,70), "Retry")) {
			Application.LoadLevel("Level 2");
			Screen.showCursor = false;
		}
		if (GUI.Button (new Rect (930, 800, 200,70), "Exit")) {
			Application.LoadLevel("Menu");
		}

	}
	public static void AutoResize(int screenWidth, int screenHeight)
	{
		Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
	}	
}
