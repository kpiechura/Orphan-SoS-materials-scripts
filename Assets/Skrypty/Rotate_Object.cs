using UnityEngine;
using System.Collections;

public class Rotate_Object : MonoBehaviour {

	public float move=100;

	void Update () {
		transform.Rotate(Vector3.left * move * Time.deltaTime);
	}
}
