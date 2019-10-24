using UnityEngine;
using System.Collections;

public class Lev4_Lock_Move : MonoBehaviour {
	
	private CharacterMotor chMotor;
	
	void Update() {
		chMotor = GetComponent<CharacterMotor>();
		chMotor.canControl = false;
		GetComponent<MouseLook>().enabled = false;
		transform.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
		StartCoroutine("Turn");
	}
	
	IEnumerator Turn(){
		yield return new WaitForSeconds(1);
		chMotor = GetComponent<CharacterMotor>();
		chMotor.canControl = true;
		GetComponent<MouseLook>().enabled = true;
		transform.Find("Main Camera").GetComponent<MouseLook>().enabled = true;
	}
	
}

