using UnityEngine;
using System.Collections;

public class Ping_Var : MonoBehaviour {

	private CharacterMotor chMotor;
	public GameObject cam;
	public static bool check=true;
	public static bool get=false;
	public byte lev;

	void Update () {

		if(New_Print_Image.pos)
		{
			RotFunc();
			chMotor = GetComponent<CharacterMotor>();
			chMotor.canControl = false;
			GetComponent<MouseLook>().enabled = false;
			transform.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
		}
	}
	void RotFunc(){

		if(check){
			get=true;
			cam.transform.Rotate(350, 180, 0);
			StartCoroutine("Anim");
			check=false;
		}
	}
	IEnumerator Anim()
	{
		yield return new WaitForSeconds(5);
		cam.animation.Play ();
		StartCoroutine("NewLev");
	}
	IEnumerator NewLev()
	{
		yield return new WaitForSeconds(12.7f);
		//tutaj bylo
		get=false;
		New_Print_Image.pos=false;
		Application.LoadLevel("Dead_Screen");
	}
}
