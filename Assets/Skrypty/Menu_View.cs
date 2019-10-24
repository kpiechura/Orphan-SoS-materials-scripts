using UnityEngine;
using System.Collections;

public class Menu_View : MonoBehaviour {

	public Texture2D Tekstura;
	public const int wys_przycisku=50;
	public const int szer_przycisku=150;

	public static bool web_check=true;

	void Start(){
			Screen.showCursor = true;
		}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0, 0,Screen.width, Screen.height), Tekstura); 
		AutoResize(1920, 1080);
		if (GUI.Button (new Rect (885, 470, 200,70), "Start")) {
			Application.LoadLevel("Wstep");
			Screen.showCursor = false;
		}
		if (GUI.Button (new Rect (885, 570, 200,70), "Extras"))  {
			Application.LoadLevel("Extras");
			web_check=true;
		}
		if (GUI.Button (new Rect (885, 670, 200,70), "Exit"))  {
			Application.Quit();
		}													
	}

	public static void AutoResize(int screenWidth, int screenHeight)
	{
		Vector2 resizeRatio = new Vector2((float)Screen.width / screenWidth, (float)Screen.height / screenHeight);
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3(resizeRatio.x, resizeRatio.y, 1.0f));
	}	
}
