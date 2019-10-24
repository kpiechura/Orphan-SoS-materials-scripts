using UnityEngine;
using System.Collections;

public class Random_Z : MonoBehaviour {

	public int pos_z1,pos_z2;
	public static int rand;
	
	void Start () {
		
		rand=Random.Range(pos_z1,pos_z2);
		transform.position = new Vector3 (transform.position.x, transform.position.y, rand);
	}
}
