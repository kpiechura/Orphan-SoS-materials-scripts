using UnityEngine;
using System.Collections;

public class Play_Time : MonoBehaviour {

	float czas=Time.time;
	
	void Update () {
		if (czas < 2) {
			czas+=Time.deltaTime;
		}
		else {
			audio.Play ();
		}
	}
}
