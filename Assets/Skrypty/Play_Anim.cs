using UnityEngine;
using System.Collections;

public class Play_Anim : MonoBehaviour {

	public Animator anim;

	void Start(){
		anim.animation.playAutomatically=false;
	}
}
