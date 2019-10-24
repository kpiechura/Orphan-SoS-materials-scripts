using UnityEngine;
using System.Collections;

public class Play_OnLevelSound : MonoBehaviour {

	void Start () {

		StartCoroutine("Wait");
	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(9.7f);
		audio.Play();
	}
}
