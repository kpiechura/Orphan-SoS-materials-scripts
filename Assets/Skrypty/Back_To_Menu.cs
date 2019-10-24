using UnityEngine;
using System.Collections;

public class Back_To_Menu : MonoBehaviour {
	
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape))
			Application.LoadLevel ("Menu");
	}
}
