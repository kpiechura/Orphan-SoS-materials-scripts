using UnityEngine;
using System.Collections;

public class Set_View_Obj : MonoBehaviour {

	public GameObject Obj1;
	public GameObject Obj2;
	public GameObject Obj3;
	public GameObject Obj4;
	public AudioClip dzwiek;
	private bool check1=true;

	public float time;

	void Start()
	{
			Obj1.gameObject.renderer.enabled=false;
			Obj2.gameObject.renderer.enabled=false;
			Obj3.gameObject.renderer.enabled=false;
			Obj4.gameObject.renderer.enabled=false;
	}

	void Update () {

		if(Ping_Var.get)
		{
			StartCoroutine("Pok1");
		}
	}
	IEnumerator Pok1()
	{
			yield return new WaitForSeconds(time);
			Obj1.gameObject.renderer.enabled=true;
			Obj2.gameObject.renderer.enabled=true;
			Obj3.gameObject.renderer.enabled=true;
			Obj4.gameObject.renderer.enabled=true;
			MusPlay();
	}  
	void MusPlay(){
		if(check1){
			audio.PlayOneShot(dzwiek);
			check1=false;
		}

	}
}
