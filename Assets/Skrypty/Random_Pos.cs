using UnityEngine;
using System.Collections;

public class Random_Pos : MonoBehaviour {

	public int pos_x1,pos_x2;
	public static int rand;

	void Start () {

		rand=Random.Range(pos_x1,pos_x2);
		transform.position = new Vector3 (rand, transform.position.y, transform.position.z);
	}
}
