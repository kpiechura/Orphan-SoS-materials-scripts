using UnityEngine;
using System.Collections;

public class Present_Destroy : MonoBehaviour {

	public Object Obiekt_zniszcz;
	public float czas1=4.6f;

void Update () {
	
		DestroyObject (Obiekt_zniszcz, czas1);
	}
}
	

