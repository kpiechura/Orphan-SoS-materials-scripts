using UnityEngine;
using System.Collections;

public class Change_Fog : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			StartCoroutine("Break");
				StartCoroutine("Break1");
					StartCoroutine("Break2");
						StartCoroutine("Break3");
							StartCoroutine("Break4");
								StartCoroutine("Break5");
									StartCoroutine("Break6");
										StartCoroutine("Break7");
		}
	}
	IEnumerator Break(){
		yield return new WaitForSeconds(1);
		RenderSettings.fogDensity=0.15f;
	}
	IEnumerator Break1(){
		yield return new WaitForSeconds(3);
		RenderSettings.fogDensity=0.13f;
	}
	IEnumerator Break2(){
		yield return new WaitForSeconds(5);
		RenderSettings.fogDensity=0.1f;
	}
	IEnumerator Break3(){
		yield return new WaitForSeconds(7);
		RenderSettings.fogDensity=0.09f;
	}
	IEnumerator Break4(){
		yield return new WaitForSeconds(9);
		RenderSettings.fogDensity=0.07f;
	}
	IEnumerator Break5(){
		yield return new WaitForSeconds(11);
		RenderSettings.fogDensity=0.05f;
	}
	IEnumerator Break6(){
		yield return new WaitForSeconds(13);
		RenderSettings.fogDensity=0.02f;
	}
	IEnumerator Break7(){
		yield return new WaitForSeconds(15);
		RenderSettings.fogDensity=0f;
	}
}
