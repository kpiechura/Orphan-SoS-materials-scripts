using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public GameObject Drzwi;
	private bool check=true;

		void OnTriggerEnter( Collider obiekt)
		{
			if (obiekt.gameObject.tag == "Player" && check) {
			    audio.Play ();
				check=false;
				Destroy (Drzwi,2);
			}			
		}
}
