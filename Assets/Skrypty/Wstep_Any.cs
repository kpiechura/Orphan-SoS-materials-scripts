using UnityEngine;
using System.Collections;

public class Wstep_Any : MonoBehaviour {

	public byte level;

	void Update () {

		if (Input.anyKeyDown)
						Application.LoadLevel (level);
	}
}
