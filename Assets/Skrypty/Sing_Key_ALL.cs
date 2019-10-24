using UnityEngine;
using System.Collections;

public class Sing_Key_ALL : MonoBehaviour {
	
	private bool check_clip=false;
	public AudioClip clip;
	
	void Update()
	{
		if(Show_Key1.var && Show_Key2.var1 && Show_Key3.var2)
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