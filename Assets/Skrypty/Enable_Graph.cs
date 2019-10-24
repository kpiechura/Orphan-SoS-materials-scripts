using UnityEngine;
using System.Collections;

public class Enable_Graph : MonoBehaviour {

	public GameObject FPC;
	private CharacterMotor chMotor;
	private bool false_update=true;
	public float time;

	void Start () {
		FPC.gameObject.renderer.enabled=false;
		chMotor = GetComponent<CharacterMotor>();
		chMotor.canControl = false;
		GetComponent<MouseLook>().enabled = false;
		transform.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
	}
	void UnFunc()
	{
		chMotor = GetComponent<CharacterMotor>();
		chMotor.canControl = true;
		GetComponent<MouseLook>().enabled = true;
		transform.Find("Main Camera").GetComponent<MouseLook>().enabled = true;
	}
	void Update(){
		if(false_update)
		{
			StartCoroutine("Enable");
			false_update=false;
		}

	}

		IEnumerator Enable()
		{
			yield return new WaitForSeconds(time);
			UnFunc();
		}
}

