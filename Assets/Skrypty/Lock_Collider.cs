using UnityEngine;
using System.Collections;

public class Lock_Collider : MonoBehaviour {

	public GameObject FPC;
	public BoxCollider Col;
	public float value;


	// Update is called once per frame
	void Update () {
		if(FPC.transform.position.z<value)
			Col.isTrigger=false;
	}
}
