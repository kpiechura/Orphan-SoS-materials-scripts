using UnityEngine;
using System.Collections;

public class AudioClip_Trigger : MonoBehaviour {

	public AudioClip clip;
	private bool trigg=true;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Player" && trigg)
		{
			audio.PlayOneShot(clip);
			trigg=false;
		}
	}
}
