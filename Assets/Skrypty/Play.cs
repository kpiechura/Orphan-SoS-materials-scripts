using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {	
	
	void Update () {
		if (gameObject.renderer.enabled == true)
			audio.Play ();
	}
}
