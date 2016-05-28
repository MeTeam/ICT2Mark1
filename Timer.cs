using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float seconds, minutes;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		minutes = (int)(Time.time / 60f);
		seconds = (int)(Time.time % 60f);
		//Debug.Log ("Time "+minutes+":"+seconds);
	}

	void OnApplicationQuit(){
		Debug.Log ("Simulation takes: "+minutes+":"+seconds);
	}
}
