using UnityEngine;
using System.Collections;

public class Only_Destroy : MonoBehaviour {

	public GameObject tak;
	public AudioSource source;
	public AudioSource plays;
	public float zmienna;
	public float var;
	public GameObject nie;

	public GameObject obiekt1;
	public GameObject obiekt2;
	public GameObject obiekt3;
	public GameObject obiekt4;

	void OnTriggerEnter( Collider obiekt)
	{
		if (obiekt.gameObject.tag == "Player") {
			source.audio.Play ();
			Destroy (tak);
			StartCoroutine("waitAndHide");
			StartCoroutine("Myself");
		}			
	}
	IEnumerator waitAndHide()
	{
		yield return new WaitForSeconds(zmienna);
		obiekt1.gameObject.renderer.enabled=false;
		obiekt2.gameObject.renderer.enabled=false;
		obiekt3.gameObject.renderer.enabled=false;
		obiekt4.gameObject.renderer.enabled=false;
	}  
	IEnumerator Myself()
	{
		yield return new WaitForSeconds (var);
		StartCoroutine("Yourself");
	}
	IEnumerator Yourself()
	{
		yield return new WaitForSeconds (1);
		Destroy (nie);
	}
}