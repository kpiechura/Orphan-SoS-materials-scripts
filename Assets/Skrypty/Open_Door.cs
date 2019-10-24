using UnityEngine;
using System.Collections;

public class Open_Door : MonoBehaviour 
{	
	bool showTip = false;
	bool enter=false;

	private bool check_var=true;

	public GameObject object1;
	public GameObject ob;
	public GameObject ob2;
	public GameObject Obj1,Obj2,Obj3,Obj4;
	public static bool locker=false;

	void Update()
	{

		if(Show_For_Key.otworz && enter && Input.GetKeyDown(KeyCode.E) && check_var)
		{
			StartCoroutine("Anim");
			StartCoroutine("Ukryj");
			StartCoroutine("Load");
			locker=true;
			ob2.gameObject.renderer.enabled=false;
			StartCoroutine("Enable");
			StartCoroutine("Sleep");
			check_var=false;
		}
	}

	void OnGUI()
	{
		if (!Show_For_Key.otworz && showTip && enter) {
			GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 150, 30), "You need a key");
		}
		
		if (Show_For_Key.otworz && showTip && enter) {
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
	void OnTriggerExit(Collider other){
		enter=false;
	}
	IEnumerator Sleep()
	{
		yield return new WaitForSeconds(3);
		audio.Play ();
	}
	IEnumerator Enable()
	{
		yield return new WaitForSeconds(3);
		gameObject.renderer.enabled=false;
	}
	IEnumerator Anim()
	{
		yield return new WaitForSeconds(3);
		ob.animation.Play("Lev_1_Exit_Anim");
	}
	IEnumerator Load()
	{
		yield return new WaitForSeconds(15);
		Application.LoadLevel("Chapter2");
	}
	IEnumerator Ukryj()
	{
		yield return new WaitForSeconds(10);
		Obj1.gameObject.renderer.enabled=false;
		Obj2.gameObject.renderer.enabled=false;
		Obj3.gameObject.renderer.enabled=false;
		Obj4.gameObject.renderer.enabled=false;
	}  
}