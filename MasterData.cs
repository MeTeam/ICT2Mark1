using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using System.Text;
using System.IO;
using System;
public class MasterData : MonoBehaviour {
	static int countStart=0;
	public static int countScene = 0;
	static int grandCountScene = 0;
	public  string[] SceneName;
	public  bool[] SceneSpider;
	public  bool[] SceneCup;
	public 	string[] SceneSpiderNum;
	//public Camera OvrLeftCup;
	//public Camera OvrRightCup;
	//public Camera OvrLeftNoCup;
	//public Camera OvrRightNoCup;

	public GameObject GUICup;
	public GameObject GUINoCup;

	//public GameObject ovrcup;
	//public GameObject quadcup;
	//public GameObject ovrnocup;
	//public GameObject quadnocup;
	public bool cupNow = false;
	public 	bool cuppp=false;
	public bool cupX=false;
	public bool spiderNow = false;

	public GameObject Oobject;

	public CupDetect cupMan = new CupDetect();
	/*public string SceneName1;
	public string SceneName2;
	public string SceneName3;
	public string SceneName4;
	public string SceneName5;
	public string SceneName6;

	public bool SceneCup1;
	public bool SceneCup2;
	public bool SceneCup3;
	public bool SceneCup4;
	public bool SceneCup5;
	public bool SceneCup6;

	public bool SceneSpider1;
	public bool SceneSpider2;
	public bool SceneSpider3;
	public bool SceneSpider4;
	public bool SceneSpider5;
	public bool SceneSpider6;*/

	// Use this for initialization
	void Start () {
		if (countStart == 1) {
			SceneName = new string[6];
			SceneSpider = new bool[6];
			SceneCup = new bool[6];
			SceneSpiderNum = new string[6];
		}
		countStart++;
		Debug.Log (countScene);
		Debug.Log ("CUp check:  " + cupCheck ());
		if (cupCheck () == true) {
				Debug.Log (Application.loadedLevelName.ToString ());
				Debug.Log ("I'm Here");
				GUICup.SetActive (true);
				GUINoCup.GetComponent<Canvas> ().enabled = false;
				//kamehameha();
				if(SpiderCheck()==true){
				spiderNow=true;
			}
			else if(SpiderCheck()==false){
				spiderNow=false;
			}
				cupX = true;
				cupNow = true;
				Debug.Log ("NowHere");
			} else if (cupCheck () == false) {
			try{
				GUINoCup.SetActive (true);
			}
			catch(NullReferenceException e){
			}
			GUICup.GetComponent<Canvas> ().enabled = false;
			cuppp = true;
			cupNow = false;
				//cuppp.GetComponent<CupDetect> ().DesSpider ();
				//cuppp.GetComponent<CupDetect> ().SuperdestroyMe ();

		}
	}
	
			
		
	
	
	// Update is called once per frame
	void Update () {
		if(cuppp){
			//Debug.Log("SSS");
			Destroy(GameObject.Find("SuperCup 1(Clone)"));
			cuppp=false;
		}
		else if(cupX){
			CupDetect	xx = GameObject.Find("SuperCup 1(Clone)").GetComponent<CupDetect>();
			xx.DesSpider();
			/*if(spiderNow==false){

			}*/
			//Bedroom
			Destroy(GameObject.Find("pills1 1(Clone)"));
			//Class
			Destroy(GameObject.Find("book05 1(Clone)"));
			//Garden
			Destroy(GameObject.Find("horseStatue(Clone)"));
			//Kitchen
			Destroy(GameObject.Find("vase1 1(Clone)"));
			//Library
			Destroy(GameObject.Find("Gift_3(Clone)"));
			//Office
			Destroy(GameObject.Find("vase2(Clone)"));
			//Park
			Destroy(GameObject.Find("EGG(Clone)"));
			//Receptionist
			Destroy(GameObject.Find("SoclePub 1(Clone)"));

			cupX=false;
		}

	
	}



	public void ShowResultFromArray(){
		for(int i =0; i<SceneName.Length; i++){
			Debug.Log ("SceneName: "+SceneName[i]+", "+"Cup: "+SceneCup[i]+", "+"Spider: "+SceneSpider[i]+", "+"num: "+SceneSpiderNum[i]);
		}
	}

	public void readSceneFile(){
		SceneName = new string[6];
		SceneSpider = new bool[6];
		SceneCup = new bool[6];
		SceneSpiderNum = new string[6];

		StreamReader readScene = new StreamReader (Application.dataPath + "SceneData.txt");
		StreamReader readCup = new StreamReader (Application.dataPath + "CupData.txt");
		StreamReader readSpider = new StreamReader (Application.dataPath + "SpiderData.txt");
		StreamReader readSpiderNum = new StreamReader (Application.dataPath + "Cacad.txt");

		string line ="";
		int i = 0;

		while(line!=null){
			line = readScene.ReadLine();
			if(line!=null){
				SceneName[i]=line.ToString();
			}
			i++;
		}
		readScene.Close ();

		string lines = "";
		int ii = 0;
		while(lines!=null){
			lines = readCup.ReadLine();
			if(lines!=null){
				bool check = bool.Parse(lines);
				SceneCup[ii]= check;
				//Debug.Log ("From array read sceneCup :"+check);
			}
			ii++;
		}
		readCup.Close ();

		string lines3 = "";
		int i3 = 0;
		while(lines3!=null){
			lines3 = readSpider.ReadLine();
			if(lines3!=null){
				bool check = bool.Parse(lines3);
				SceneSpider[i3]= check;
				//Debug.Log ("From array read sceneCup :"+check);
			}
			i3++;
		}
		readSpider.Close();

		string lines4 = "";
		int i4 = 0;
		while(lines4!=null){
			lines4 = readSpiderNum.ReadLine();
			if(lines4!=null){
				string check = lines4;
				SceneSpiderNum[i4]= check;
				//Debug.Log ("From array read sceneCup :"+check);
			}
			i4++;
		}
		readSpiderNum.Close();
	}
	


	public void loadScene(){
		readSceneFile ();
		Debug.Log ("Scene grandmaster:::"+grandCountScene);
		Debug.Log ("Scene grandmasterXXXX:::"+countScene);


		//Debug.Log ("Load scene sukse");
		//first iteration happen here
		if((countScene-2)==1 && (grandCountScene==0)){
			resetCountScene();
			addGrandCountScene();
		}
		//after first iteration
		else if((countScene-2)==1 && (grandCountScene==1)){
			Debug.Log ("First Iteratiojn finish");
		}
		//second iteration happen here
		 else if((countScene-5)==1 && (grandCountScene==1)){
			Debug.Log ("Masuk Cuy");
			Debug.Log ("count scene di 2nd: "+countScene);
			resetCountScene();
			Debug.Log ("count scene di 2nd: "+countScene);
			addGrandCountScene();
		}
		//after second iteration
		else if((countScene-5)==1 && (grandCountScene==2)){
			Application.LoadLevel("InterrogrationRoom");
		}

		if(SceneCup[countScene]==true && countScene!=6){
			cupNow = true;
		}
		else if(SceneCup[countScene]==false && countScene!=6){
			cupNow=false;
		}

		addCountScene ();
		//Debug.Log ("#: "+SceneName.Length);
		//Debug.Log (SceneName[countScene-1].ToString());
		Application.LoadLevel (SceneName[countScene-1].ToString());
	}
	
	public bool cupCheck(){
		readSceneFile ();
		for(int i=0; i<SceneCup.Length; i++){
			Debug.Log ("SceneCup "+i+" ="+SceneCup[i].ToString());
		}
		//Debug.Log ("Cup IS= " + SceneCup[countScene-1].ToString());
		Debug.Log ("COunt Scene:  "+countScene);
	
		if ((SceneCup [countScene - 1]) == true) {
			return true;
		}
		
		
		return false;
	}


	public bool SpiderCheck(){
		readSceneFile ();
		for(int i=0; i<SceneSpider.Length; i++){
			Debug.Log ("SceneSpider "+i+" ="+SceneSpider[i].ToString());
		}
		//Debug.Log ("Cup IS= " + SceneCup[countScene-1].ToString());
		Debug.Log ("COunt Scene:  "+countScene);
		
		if ((SceneSpider [countScene - 1]) == true) {
			return true;
		}
		
		
		return false;
	}

	public void addCountScene(){
		countScene++;
	}

	public void resetCountScene(){
		countScene = countScene - 3;
	}
	public void addGrandCountScene(){
		Debug.Log ("ADDgrandcountscene jadi");
		grandCountScene++;
	}
	public void kamehameha(){
		Oobject.renderer.enabled = false;
		Oobject.collider.enabled = false;
	}

	public int turnCount(){
		return countScene;
	}
}
