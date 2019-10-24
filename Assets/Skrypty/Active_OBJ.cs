using UnityEngine;
using System.Collections;

public class Active_OBJ : MonoBehaviour {

	public float time;

	public GameObject Obj1;
	public GameObject Obj2;
	public GameObject Obj3;
	public GameObject Obj4;
	private bool show=true;

	void Start(){
		Obj1.gameObject.renderer.enabled=false;
		Obj2.gameObject.renderer.enabled=false;
		Obj3.gameObject.renderer.enabled=false;
		Obj4.gameObject.renderer.enabled=false;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && show) {
			audio.Play ();
		Obj1.gameObject.renderer.enabled=true;
		Obj2.gameObject.renderer.enabled=true;
		Obj3.gameObject.renderer.enabled=true;
		Obj4.gameObject.renderer.enabled=true;
			StartCoroutine("Disab");
		}
	}
	IEnumerator Disab()
	{
		yield return new WaitForSeconds(time);
		show=false;
		Start ();
	}
}
