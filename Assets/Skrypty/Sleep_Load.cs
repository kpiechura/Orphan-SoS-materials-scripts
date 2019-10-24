using UnityEngine;
using System.Collections;

public class Sleep_Load : MonoBehaviour {

		float czas=0;
		
		void Update () {
			if (czas < 15) {
				czas+=Time.deltaTime;
			}
			else {
				Application.LoadLevel (4);
			}
		}
	}
	

	

