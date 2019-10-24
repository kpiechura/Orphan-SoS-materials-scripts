using UnityEngine;
using System.Collections;

public class Double_Tap : MonoBehaviour {
	
	public float tapSpeed = 10f; //in seconds
	
	private float lastTapTime = 0;
	
	// Use this for initialization
	
	void Start () {
		
		lastTapTime = 0;
		
	}
	
	// Update is called once per frame
	
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space)){
			
			if((Time.time - lastTapTime) < tapSpeed){
				
				Debug.Log("Double tap");
				
			}
			
			lastTapTime = Time.time;
			
		}
		
	}
	
}