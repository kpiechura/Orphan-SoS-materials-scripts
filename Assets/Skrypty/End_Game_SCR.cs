using UnityEngine;
using System.Collections;

public class End_Game_SCR : MonoBehaviour {

	public GameObject[] obj=new GameObject[12]; 
	public AudioClip clip,clip2,clip3;
	public GameObject anim,FPC;
	public static bool lck_FPC=false;
	public static bool play_sound=false;

	private bool active_trigg=true;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}

	void Start () {
		for(int i=0; i<12; ++i)
		{
			obj[i].gameObject.renderer.enabled=false;
		}
		FPC.gameObject.renderer.enabled=false;
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="Player" && active_trigg)
		{
			lck_FPC=true;
			StartCoroutine("Part1");
		}
	}
	IEnumerator Part1()
	{
		yield return new WaitForSeconds(5);

		RenderSettings.fogDensity=0.5f;
		for(int i=0; i<4; ++i)
		{
			obj[i].gameObject.renderer.enabled=true;

		}
		play_sound=true;
		audio.PlayOneShot(clip);
		StartCoroutine("Part2");

	}
	IEnumerator Part2()
	{
		yield return new WaitForSeconds(15);
		anim.animation.Play("End_Game_Anim");
		StartCoroutine("Part0");
		StartCoroutine("Part3");
		for(int i=4; i<12; ++i)
		{
			obj[i].gameObject.renderer.enabled=true;
			
		}
		audio.PlayOneShot(clip2);
	}
	IEnumerator Part0()
	{
		yield return new WaitForSeconds(9);
		audio.PlayOneShot(clip3);
	}
	IEnumerator Part3()
	{
		yield return new WaitForSeconds(11);
		RenderSettings.fogDensity=0.7f;
		StartCoroutine("Part4");
	}
	IEnumerator Part4()
	{
		yield return new WaitForSeconds(1);
		RenderSettings.fogDensity=0.9f;
		StartCoroutine("Part6");
	}
	IEnumerator Part6()
	{
		yield return new WaitForSeconds(4);
		Application.LoadLevel("END_1");
		
	}
}

