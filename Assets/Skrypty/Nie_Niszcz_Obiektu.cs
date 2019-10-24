using UnityEngine;
using System.Collections;

public class Nie_Niszcz_Obiektu : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
}
