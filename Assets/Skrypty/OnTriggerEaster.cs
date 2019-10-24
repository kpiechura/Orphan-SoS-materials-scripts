using UnityEngine;
using System.Collections;

public class OnTriggerEaster : MonoBehaviour {

	private bool check=true;

	void OnTriggerEnter( Collider other)
	{
		if (other.tag == "Player" && check) {
			Application.LoadLevel("Easter");
			check=false;
		}
		
	}
}
