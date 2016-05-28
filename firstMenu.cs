using UnityEngine;
using System.Collections;

public class firstMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.showCursor = true;
		Screen.lockCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
		Screen.showCursor = true;
		Screen.lockCursor = false;
	}
	public void runTest(){
		Application.LoadLevel ("practiceRoom");
	}

	public void runSim(){
		Application.LoadLevel ("2ndMenu");
	}

	public void exit(){
		Application.Quit ();
	}
}
