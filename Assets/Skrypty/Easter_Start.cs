using UnityEngine;
using System.Collections;

public class Easter_Start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
		RenderSettings.fog=true;
		RenderSettings.fogDensity=0.7f;
		StartCoroutine("Scene");
	}
	IEnumerator Scene()
	{
		yield return new WaitForSeconds(31);
		RenderSettings.fog=false;
	}
}
