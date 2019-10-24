using UnityEngine;
using System.Collections;

public class On_Enter : MonoBehaviour {

	public AudioSource source;
	private bool check_val=true;

	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag=="Player" && check_val)
			source.audio.Play ();
			check_val=false;
	}
}
