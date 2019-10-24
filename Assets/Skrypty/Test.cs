using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			animation.Play ("sleep");
		}
	}
}
