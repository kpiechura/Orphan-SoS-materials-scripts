using UnityEngine;
using System.Collections;

public class Lock_Move : MonoBehaviour {

	private CharacterMotor chMotor;
	
	void Update(){
		if(Open_Door.locker)
			Func();
	}
	
	void Func () {
		chMotor = GetComponent<CharacterMotor>();
		chMotor.canControl = false;
		GetComponent<MouseLook>().enabled = false;
		transform.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
	}
	
}

