using UnityEngine;
using System.Collections;

public class Get_3_Keys : MonoBehaviour 
{	
	bool showTip = false;
	bool enter=false;
	private bool checker=true;

	public GameObject FPC;
	public static bool locker=false;
	private bool var_check=true;
	
	void Update()
	{
		
		if((Show_Key1.var && Show_Key2.var1 && Show_Key3.var2)&& enter && Input.GetKeyDown(KeyCode.E))
		{
			locker=true;
			Enter();
		}
	}
	
	void OnGUI()
	{
		if (!(Show_Key1.var && Show_Key2.var1 && Show_Key3.var2) && showTip && enter) {
			GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 150, 30), "You need a keys");
		}
		
		if ((Show_Key1.var && Show_Key2.var1 && Show_Key3.var2) && showTip && enter) {
			GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 150, 30), "Press 'E' to open door");
		}
	}
	
	void OnTriggerEnter( Collider other)
	{
		if (other.tag == "Player") {
			enter=true;
			showTip = true;
		}
		
	}
	void Enter(){
		if(checker)
		{
			FPC.animation.Play ("Lev_3_End_Anim");
			StartCoroutine("Dis_Play");
			checker=false;
		}
	}
	void OnTriggerExit(Collider other){
		enter=false;
	}
	void PlayAud(){
		if(var_check)
		{
			audio.Play ();
			var_check=false;
		}
	}
	IEnumerator Dis_Play(){
		yield return new WaitForSeconds(2);
		audio.Play ();
		gameObject.renderer.enabled=false;
		StartCoroutine("New_Lev");
	}
	IEnumerator New_Lev(){
		yield return new WaitForSeconds(1.4f);
		Application.LoadLevel("Chapter4");
	}
}