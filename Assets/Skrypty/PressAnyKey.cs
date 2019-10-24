using UnityEngine;
using System.Collections;

public class PressAnyKey : MonoBehaviour {
	
	float czas=Time.time;

	void Update () {
			if (Input.anyKeyDown)
				Application.LoadLevel (2);
	}
}
