using UnityEngine;
using System.Collections;

public class FPC_Pos : MonoBehaviour {

	public GameObject Ob;

	void Update () {

		if(gameObject.transform.position.z==(Ob.gameObject.transform.position.z+5))
			Debug.Log ("Orphan");

		if(gameObject.transform.position.y<-70)
			Application.LoadLevel (11);
	}
}
