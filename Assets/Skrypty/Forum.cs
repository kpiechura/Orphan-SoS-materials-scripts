using UnityEngine;
using System.Collections;

public class Forum : MonoBehaviour {

	public AudioSource s1;
	public AudioSource s2;

	void OnTriggerEnter(Collider inne)
	{
		if(inne.gameObject.tag=="Player")
			s1.audio.Play ();

		StartCoroutine("sound");
	}
	
	IEnumerator sound()
	{
		yield return new WaitForSeconds(2);
		s2.audio.Play ();
	}  
}
