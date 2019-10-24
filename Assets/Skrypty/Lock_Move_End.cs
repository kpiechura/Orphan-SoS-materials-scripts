using UnityEngine;
using System.Collections;

public class Lock_Move_End : MonoBehaviour {
	
	private CharacterMotor chMotor;
	
	void Update(){
		if(Get_3_Keys.locker)
			Func();
	}
	
	void Func () {
		chMotor = GetComponent<CharacterMotor>();
		chMotor.canControl = false;
		GetComponent<MouseLook>().enabled = false;
		transform.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
	}
	
}

