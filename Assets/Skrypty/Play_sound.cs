using UnityEngine;
using System.Collections;

public class Play_sound : MonoBehaviour {

	public AudioSource source;
	public bool tak=false;
	void OnTriggerEnter(Collider other)
	{
		if(gameObject.tag=="Player")
		{
			tak=true;
			source.audio.Play ();
		}
	}
}
