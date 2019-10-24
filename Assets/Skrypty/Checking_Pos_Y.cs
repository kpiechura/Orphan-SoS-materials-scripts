using UnityEngine;
using System.Collections;

public class Checking_Pos_Y: MonoBehaviour {
	
	void Update () {

		if(gameObject.transform.position.y<-70)
			Application.LoadLevel ("Menu");
	}
}
