using UnityEngine;
using System.Collections;

public class CheckPos2 : MonoBehaviour {
	
	public float pos;
	
	void Update () {
		if(gameObject.transform.position.y<pos)
			Application.LoadLevel("Dead_Scene_2");
	}
}
