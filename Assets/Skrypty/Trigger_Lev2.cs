using UnityEngine;
using System.Collections;

public class Trigger_Lev2 : MonoBehaviour {

	private bool check_tgg=true;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && check_tgg) {
				audio.Play ();
				check_tgg=false;
		}
	}
}
