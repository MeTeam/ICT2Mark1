using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinGame : MonoBehaviour {
	public static int winCount;

	public GameObject count;
	public GameObject countX;
	// Use this for initialization
	void Start () {
		winCount = 0;
		count.GetComponent<Text> ().text = winCount.ToString()+"/3";
		countX.GetComponent<Text> ().text = winCount.ToString()+"/3";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addWinCount(){
		Debug.Log ("WIncountsucc");
		winCount++;
		count.GetComponent<Text> ().text = winCount.ToString()+"/3";
		countX.GetComponent<Text> ().text = winCount.ToString()+"/3";
	}

	public bool checkWin(){
		if(winCount==3){
			return true;
		}
		return false;
	}
}
