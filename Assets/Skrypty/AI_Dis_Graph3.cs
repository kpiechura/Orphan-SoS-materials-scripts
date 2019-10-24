using UnityEngine;
using System.Collections;

public class AI_Dis_Graph3 : MonoBehaviour {
	
	public GameObject Obj1;
	public GameObject Obj2;
	public GameObject Obj3;
	public GameObject Obj4;
	
	private bool check_coll=false;
	private bool check_reply=true;
	
	void Start () {
		Obj1.gameObject.renderer.enabled=false;
		Obj2.gameObject.renderer.enabled=false;
		Obj3.gameObject.renderer.enabled=false;
		Obj4.gameObject.renderer.enabled=false;
	}
	void Update()
	{
		if(Show_Key3.var2)
		{
			check_coll=true;
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && check_coll && check_reply)
		{
			Enab_Graph();
			check_coll=false;
			check_reply=false;
		}
	}
	void Enab_Graph()
	{
		audio.Play();
		Obj1.gameObject.renderer.enabled=true;
		Obj2.gameObject.renderer.enabled=true;
		Obj3.gameObject.renderer.enabled=true;
		Obj4.gameObject.renderer.enabled=true;
		StartCoroutine("Dis_Graph");
	}
	IEnumerator Dis_Graph(){
		yield return new WaitForSeconds(0.5f);
		Obj1.gameObject.renderer.enabled=false;
		Obj2.gameObject.renderer.enabled=false;
		Obj3.gameObject.renderer.enabled=false;
		Obj4.gameObject.renderer.enabled=false;
	}
}
