using UnityEngine;
using System.Collections;

public class EmptyObject_for_Other : MonoBehaviour {

	public AudioSource source;

	void Update () {
		if (Screamer_New.play == true) {
			source.audio.Play ();
				}
	}
}
