using UnityEngine;
using System.Collections;

public class Check_Position : MonoBehaviour {

	public float pos;

	void Update () {
		if(gameObject.transform.position.y<pos)
			Application.LoadLevel("Dead_Screen");
	}
}
