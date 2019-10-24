using UnityEngine;
using System.Collections;

public class Destroy_Big_Door : MonoBehaviour {

	public GameObject FPC;

	void OnTriggerEnter( Collider other)
	{
		if (other.gameObject.tag == "Player") {
			FPC.animation.Play ("Lev_2_End_Anim");
			StartCoroutine("Enab");
		}		

	}
	IEnumerator Enab()
	{
		yield return new WaitForSeconds(5.5f);

		audio.Play ();
		//gameObject.renderer.enabled=false;
		StartCoroutine("Lev");

	}
	IEnumerator Lev()
	{
		yield return new WaitForSeconds(2f);

		Application.LoadLevel("Chapter3");
	}
}

