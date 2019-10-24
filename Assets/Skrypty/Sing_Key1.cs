using UnityEngine;
using System.Collections;

public class Sing_Key1 : MonoBehaviour {

	private bool check_clip=false;
	public AudioClip clip;

	void Update()
	{
		if(Show_Key1.var)
		{
			check_clip=true;
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && check_clip)
		{
			audio.PlayOneShot(clip);
			check_clip=false;
		}
	}
}