using UnityEngine;
using System.Collections;

public class Screamer_New : MonoBehaviour {

	public GameObject Obj1;
	public GameObject Obj2;
	public GameObject Obj3;
	public GameObject Obj4;
	public static bool play;

	public float zmienna=1;
	public int zak1=1;
	public int zak2=80;
	public bool pok=true;

	void Start(){
		EnableFalse();
		play=false;
		}

	void OnTriggerEnter(Collider gameObject)
	{
		if (gameObject.tag == "Player" && pok==true) {
				audio.Play();
				Pokaz ();
				play=true;
				StartCoroutine("Ukryj");

	}
	}
	void OnTriggerExit()
	{
		pok=false;
	}
	IEnumerator Ukryj()
	{
		yield return new WaitForSeconds(zmienna);
		Obj1.gameObject.renderer.enabled=false;
		Obj2.gameObject.renderer.enabled=false;
		Obj3.gameObject.renderer.enabled=false;
		Obj4.gameObject.renderer.enabled=false;
	}  

	void Pokaz()
	{
		Obj1.gameObject.renderer.enabled=true;
		Obj2.gameObject.renderer.enabled=true;
		Obj3.gameObject.renderer.enabled=true;
		Obj4.gameObject.renderer.enabled=true;
	}

	void EnableFalse()
	{
		Obj1.gameObject.renderer.enabled=false;
		Obj2.gameObject.renderer.enabled=false;
		Obj3.gameObject.renderer.enabled=false;
		Obj4.gameObject.renderer.enabled=false;
	}

}
