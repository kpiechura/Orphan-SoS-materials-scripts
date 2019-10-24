using UnityEngine;
using System.Collections;

public class Play_Sound1 : MonoBehaviour {

	private bool check=true;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player"&& check) {
			audio.Play ();
			check=false;
		}
	}
}
