using UnityEngine;
using System.Collections;

public class Picture_Check : MonoBehaviour {

	public GameObject Obj1;
	public GameObject Obj2;
	public GameObject Obj3;
	public GameObject Obj4;

	private bool check_enab=true;

	void Start(){
		Obj1.gameObject.renderer.enabled=false;
		Obj2.gameObject.renderer.enabled=false;
		Obj3.gameObject.renderer.enabled=false;
		Obj4.gameObject.renderer.enabled=false;
	}
	void Update () {
		if(Modified_Print_Picture_Scr.pic_check)
		{
			StartCoroutine("Enab_Graph");
		}
	}
	IEnumerator Enab_Graph()
	{
		yield return new WaitForSeconds(1);
		Checking_Func();
	}
	void Checking_Func(){
		if(check_enab)
		{
			audio.Play();
			Obj1.gameObject.renderer.enabled=true;
			Obj2.gameObject.renderer.enabled=true;
			Obj3.gameObject.renderer.enabled=true;
			Obj4.gameObject.renderer.enabled=true;
			StartCoroutine("Change_Enab");
			check_enab=false;
		}
	}
	IEnumerator Change_Enab()
	{
		yield return new WaitForSeconds(0.5f);
		Start();
	}
}
