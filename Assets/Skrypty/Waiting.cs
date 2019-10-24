using UnityEngine;
using System.Collections;

public class Waiting : MonoBehaviour {

	float czas=Time.time;

	void Update () {
		if (czas < 5) {
			czas+=Time.deltaTime;
			}
			else {
				Application.LoadLevel (4);
			}
		}
	}

