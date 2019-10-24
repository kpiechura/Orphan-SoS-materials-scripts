using UnityEngine;
using System.Collections;

public class Wstep_Dest1 : MonoBehaviour {

	public Object obiekt_zniszcz;

	void Start(){
		
		gameObject.renderer.enabled = true;
		DestroyObject (obiekt_zniszcz, 5);
		
	}
}
