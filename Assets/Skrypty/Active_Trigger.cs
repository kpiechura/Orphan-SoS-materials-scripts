using UnityEngine;
using System.Collections;

public class Active_Trigger : MonoBehaviour {

	private bool trigg=true;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && trigg) {
			if(Show_For_Key.otworz)
			{
				audio.Play ();
				trigg=false;
			}
		}
	}
}
