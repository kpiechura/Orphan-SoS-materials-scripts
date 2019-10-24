using UnityEngine;
using System.Collections;

public class Krok : MonoBehaviour {

	public static bool move=false;

	void Update () {
		if (Input.GetKeyDown (KeyCode.W)|| Input.GetKeyDown(KeyCode.S)) {
			audio.Play ();
			audio.loop=true;
			move=true;
		}
		if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp(KeyCode.S))	
			audio.Stop ();
		    move = false;
	}
}

