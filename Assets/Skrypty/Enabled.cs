using UnityEngine;
using System.Collections;

public class Enabled : MonoBehaviour {

	public GameObject obiekt;
	float czas=Time.time;

	void Start () {
		obiekt.renderer.enabled = false;
	}

		void Update () {
			if (czas < 5) {
				czas+=Time.deltaTime;
			}
			else {
				obiekt.renderer.enabled=true;
			}
	}
}
	

