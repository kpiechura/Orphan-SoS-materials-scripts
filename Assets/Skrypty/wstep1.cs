using UnityEngine;
using System.Collections;

public class wstep1 : MonoBehaviour {

	public float time;

	void Start () {
		gameObject.renderer.enabled = true;

	}
	void Update () {
	
		Destroy (gameObject, time);
	}
}
