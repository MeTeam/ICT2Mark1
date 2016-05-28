using UnityEngine;
using System.Collections;

public class PauseGame :MonoBehaviour {

	private int buttonWidth = 300;
	private int buttonHeight = 100;
	private int groupWidth = 300;
	private int groupHeight = 220;
	public GameObject PausedOculus;
	public GameObject LibraryCanvas;
	public GameObject nocupCanvas;
	public GameObject resumeButton;
	public GameObject exitButton;

	//private OVRCameraRig x;
	bool paused = false;
	// Use this for initialization
	void Start () {
		GameObject.Find ("OVRPlayerController").GetComponent<OVRGamepadController> ().enabled = true;
		PausedOculus.SetActive (false);
		LibraryCanvas.SetActive (true);
		nocupCanvas.SetActive (true);
		//x = transform.FindChild ("PauseOculus").gameObject.SetActive(false);
		Screen.lockCursor = true;
		Time.timeScale = 1;
	}

     /*public override void OnVRGUI(){
		if (paused) {
			GUILayout.BeginArea(new Rect(((Screen.width/2)-(groupWidth/2)),((Screen.height/2)-(groupHeight/2)), groupWidth, groupHeight));
			if(GUILayout.Button("Main Menu"))
			{
				Application.Quit();
			}
			if(GUILayout.Button("Quit Simulation"))
			{
				Application.Quit();
			}
			GUILayout.EndArea();
		}
	}*/


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape) || Input.GetKeyUp (KeyCode.P)) {
			paused= togglePuase();
		}
		else if(paused && Input.GetKeyUp (KeyCode.X)){
			//Debug.Log ("Quit Triggered");
			Application.LoadLevel("1stMenu");
		}
	}

	bool togglePuase(){
		if (Time.timeScale == 0) {
			GameObject.Find ("OVRPlayerController").GetComponent<OVRGamepadController> ().enabled = true;
			Screen.lockCursor = true;
			Time.timeScale = 1;
			PausedOculus.SetActive (false);
			LibraryCanvas.SetActive (true);
			nocupCanvas.SetActive(true);
			return(false);
		}
		else {
			GameObject.Find ("OVRPlayerController").GetComponent<OVRGamepadController> ().enabled = false;
			Screen.lockCursor = false;
			Time.timeScale = 0;
			PausedOculus.SetActive (true);
			LibraryCanvas.SetActive (false);
			nocupCanvas.SetActive(false);
			return(true);
		}
	}

	public void resumePressed(){
		Debug.Log ("Hello its me");
	}
}
