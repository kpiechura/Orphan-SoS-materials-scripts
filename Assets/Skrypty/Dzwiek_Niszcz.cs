using UnityEngine;
using System.Collections;

public class Dzwiek_Niszcz : MonoBehaviour {

	public GameObject obiekt;
	public byte level;

	void Update () {

		if(Application.loadedLevel==level)
			Destroy(gameObject);
	}
}
