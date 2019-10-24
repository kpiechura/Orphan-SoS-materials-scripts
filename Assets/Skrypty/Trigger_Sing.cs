using UnityEngine;
using System.Collections;

public class Trigger_Sing : MonoBehaviour {

	private bool loop=true;

	void OnTriggerEnter(Collider other)
	{
		if(Show_For_Key.otworz && loop==true)
			audio.Play ();
			loop=false;
	}
	void OnTriggerExit(Collider other)
	{
		loop=false;
	}
}
