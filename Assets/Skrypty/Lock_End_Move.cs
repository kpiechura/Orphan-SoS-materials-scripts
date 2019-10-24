using UnityEngine;
using System.Collections;

public class Lock_End_Move : MonoBehaviour {
	
	private CharacterMotor chMotor;
	
	void Update(){
		if(End_Game_SCR.lck_FPC)
			Func();
	}
	
	void Func () {
		chMotor = GetComponent<CharacterMotor>();
		chMotor.canControl = false;
		/*GetComponent<MouseLook>().enabled = false;
		transform.Find("Main Camera").GetComponent<MouseLook>().enabled = false;*/
	}
	
}

