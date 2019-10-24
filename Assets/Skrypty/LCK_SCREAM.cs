using UnityEngine;
using System.Collections;

public class LCK_SCREAM : MonoBehaviour {

	public GameObject[] obj=new GameObject[4]; 
	public BoxCollider col1,col2,col3,col4;
	public GameObject FPC;
	private bool active_trigg=true;

	public AudioClip clip2;
	
	void Start () {
		for(int i=0; i<4; ++i)
		{
			obj[i].gameObject.renderer.enabled=false;
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Player" && active_trigg)
		{
			StartCoroutine("Part1");
			RenderSettings.fogDensity=0.15f;
			StartCoroutine("Part1");
			FPC.animation.Play ("2_Middle_Anim");
			active_trigg=false;
			col1.isTrigger=false;
			col2.isTrigger=false;
			col3.isTrigger=false;
			col4.isTrigger=false;
		}
	}
	IEnumerator Part1()
	{
		yield return new WaitForSeconds(5);

		for(int i=0; i<4; ++i)
		{
			obj[i].gameObject.renderer.enabled=true;
			
		}
		audio.PlayOneShot(clip2);
		StartCoroutine("Part2");
	}
	IEnumerator Part2()
	{
		yield return new WaitForSeconds(1);
		Start ();
		RenderSettings.fogDensity=0.015f;
		col1.isTrigger=true;
		col2.isTrigger=true;
		col3.isTrigger=true;
		col4.isTrigger=true;
	}
}
