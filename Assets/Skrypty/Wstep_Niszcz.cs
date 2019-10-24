using UnityEngine;
using System.Collections;

public class Wstep_Niszcz : MonoBehaviour {

	public GameObject obiekt;
	public GameObject tekst;
	public GameObject obiekt1;
	float czas=Time.time;

	void Start(){

		tekst.gameObject.renderer.enabled = false;
		obiekt1.gameObject.renderer.enabled = false;

		Destroy (obiekt, 6);
		Destroy (tekst, 13);
	}

	void Update () {
		if (czas <=6 ) {
			czas+=Time.deltaTime;
		}
		else {
			tekst.gameObject.renderer.enabled = true;
		}
	}
}
