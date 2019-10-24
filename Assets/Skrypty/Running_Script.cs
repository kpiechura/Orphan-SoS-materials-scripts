using UnityEngine;
using System.Collections;

public class Running_Script : MonoBehaviour {

	public float walkSpeed = 2.0f;
	public float runSpeed = 4.5f;
	
	private CharacterController chCont;
	private CharacterMotor chMotor;

	void Start () {
		chCont = GetComponent<CharacterController>();
		chMotor = GetComponent<CharacterMotor>();
	}
	
	void FixedUpdate () {
		
		float speed = walkSpeed;
		
		if(chCont.isGrounded && Input.GetKey(KeyCode.LeftShift)) {
			speed = runSpeed;
		}	
		
		chMotor.movement.maxForwardSpeed = speed;
	}
}
