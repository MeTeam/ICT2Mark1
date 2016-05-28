using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class CancelInMenu : MonoBehaviour {
	public MasterData GameData;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Cancel1Pressed(){
		GameObject.Find ("Choice1").GetComponent<Text> ().text = "";
		GameObject.Find ("Cup1").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider1").GetComponent<Toggle> ().isOn = false;
		GameData.SceneName [0] = "Empty";
		GameData.SceneSpider [0] = false;
		GameData.SceneCup [0] = false;
		Debug.Log ("Cancel1 is pressed");
	}

	public void Cancel2Pressed(){
		GameObject.Find ("Choice2").GetComponent<Text> ().text = "";
		GameObject.Find ("Cup2").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider3").GetComponent<Toggle> ().isOn = false;
		GameData.SceneName [1] = "Empty";
		GameData.SceneSpider [1] = false;
		GameData.SceneCup [1] = false;
	}

	public void Cancel3Pressed(){
		GameObject.Find ("Choice3").GetComponent<Text> ().text = "";
		GameObject.Find ("Cup3").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider3").GetComponent<Toggle> ().isOn = false;
		GameData.SceneName [2] = "Empty";
		GameData.SceneSpider [2] = false;
		GameData.SceneCup [2] = false;
	}

	public void Cancel4Pressed(){
		GameObject.Find ("Choice12").GetComponent<Text> ().text = "";
		GameObject.Find ("Cup12").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider12").GetComponent<Toggle> ().isOn = false;
		GameData.SceneName [3] = "Empty";
		GameData.SceneSpider [3] = false;
		GameData.SceneCup [3] = false;
	}

	public void Cancel5Pressed(){
		GameObject.Find ("Choice22").GetComponent<Text> ().text = "";
		GameObject.Find ("Cup22").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider22").GetComponent<Toggle> ().isOn = false;
		GameData.SceneName [4] = "Empty";
		GameData.SceneSpider [4] = false;
		GameData.SceneCup [4] = false;
	}

	public void Cancel6Pressed(){
		GameObject.Find ("Choice32").GetComponent<Text> ().text = "";
		GameObject.Find ("Cup32").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider32").GetComponent<Toggle> ().isOn = false;
		GameData.SceneName [5] = "Empty";
		GameData.SceneSpider [5] = false;
		GameData.SceneCup [5] = false;
	}

}
