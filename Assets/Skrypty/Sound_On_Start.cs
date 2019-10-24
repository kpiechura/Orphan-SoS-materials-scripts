using UnityEngine;
using System.Collections;

public class Sound_On_Start : MonoBehaviour {
	
	void Start () {
		StartCoroutine("sound");
	}

	IEnumerator sound()
	{
		yield return new WaitForSeconds(3);
		audio.Play ();
	}  
}
