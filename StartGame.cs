using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class StartGame : MonoBehaviour {

	public MasterData GameData;
	public InputField field1;
	public InputField field2;
	public InputField field3;
	public InputField field4;
	public InputField field5;
	public InputField field6;
	// Use this for initialization
	public void showResult(){
		//GameData = GameObject.Find ("_StartGame").GetComponent<MasterData>().;
		StreamWriter writer = new StreamWriter (Application.dataPath + "SceneData.txt");
		StreamWriter writer1 = new StreamWriter (Application.dataPath + "CupData.txt");
		StreamWriter writer2 = new StreamWriter (Application.dataPath + "SpiderData.txt");
		StreamWriter writer3 = new StreamWriter (Application.dataPath + "Cacad.txt");

		string Choices1 = GameObject.Find ("Choice1").GetComponent<Text> ().text;
		string Choices2 = GameObject.Find ("Choice2").GetComponent<Text> ().text;
		string Choices3 = GameObject.Find ("Choice3").GetComponent<Text> ().text;
		string Choices12 = GameObject.Find ("Choice32").GetComponent<Text> ().text;
		string Choices22 = GameObject.Find ("Choice22").GetComponent<Text> ().text;
		string Choices32 = GameObject.Find ("Choice12").GetComponent<Text> ().text;

		GameData.SceneName [0] = Choices1;
		GameData.SceneName [1] = Choices2;
		GameData.SceneName [2] = Choices3;
		GameData.SceneName [3] = Choices32;
		GameData.SceneName [4] = Choices22;
		GameData.SceneName [5] = Choices12;

		writer.WriteLine (Choices1);
		writer.WriteLine (Choices2);
		writer.WriteLine (Choices3);
		writer.WriteLine (Choices32);
		writer.WriteLine (Choices22);
		writer.WriteLine (Choices12);
		writer.Close ();

		bool cup1 = GameObject.Find ("Cup1").GetComponent<Toggle> ().isOn;
		bool cup2 = GameObject.Find ("Cup2").GetComponent<Toggle> ().isOn;
		bool cup3 = GameObject.Find ("Cup3").GetComponent<Toggle> ().isOn;
		bool cup12 = GameObject.Find ("Cup6").GetComponent<Toggle> ().isOn;
		bool cup22 = GameObject.Find ("Cup5").GetComponent<Toggle> ().isOn;
		bool cup32 = GameObject.Find ("Cup4").GetComponent<Toggle> ().isOn;

		writer1.WriteLine (cup1.ToString());
		writer1.WriteLine (cup2.ToString());
		writer1.WriteLine (cup3.ToString());
		writer1.WriteLine (cup12.ToString());
		writer1.WriteLine (cup22.ToString());
		writer1.WriteLine (cup32.ToString());
		writer1.Close ();

		GameData.SceneCup [0] = cup1;
		GameData.SceneCup [1] = cup2;
		GameData.SceneCup [2] = cup3;
		GameData.SceneCup [3] = cup32;
		GameData.SceneCup [4] = cup22;
		GameData.SceneCup [5] = cup12;

		bool spider1 = GameObject.Find ("Spider1").GetComponent<Toggle> ().isOn;
		bool spider2 = GameObject.Find ("Spider2").GetComponent<Toggle> ().isOn;
		bool spider3 = GameObject.Find ("Spider3").GetComponent<Toggle> ().isOn;
		bool spider12 = GameObject.Find ("Spider6").GetComponent<Toggle> ().isOn;
		bool spider22 = GameObject.Find ("Spider5").GetComponent<Toggle> ().isOn;
		bool spider32 = GameObject.Find ("Spider4").GetComponent<Toggle> ().isOn;

		writer2.WriteLine (spider1.ToString());
		writer2.WriteLine (spider2.ToString());
		writer2.WriteLine (spider3.ToString());
		writer2.WriteLine (spider12.ToString());
		writer2.WriteLine (spider22.ToString());
		writer2.WriteLine (spider32.ToString());
		writer2.Close ();

		GameData.SceneSpider [0] = spider1;
		GameData.SceneSpider [1] = spider2;
		GameData.SceneSpider [2] = spider3;
		GameData.SceneSpider [3] = spider32;
		GameData.SceneSpider [4] = spider22;
		GameData.SceneSpider [5] = spider12;

		string spiderNum1 = (string)field1.text;
		string spiderNum2 = (string)field2.text;
		string spiderNum3 = (string)field3.text;
		string spiderNum4 = (string)field4.text;
		string spiderNum5 = (string)field5.text;
		string spiderNum6 = (string)field6.text;

		GameData.SceneSpiderNum [0] = spiderNum1;
		GameData.SceneSpiderNum [1] = spiderNum2;
		GameData.SceneSpiderNum [2] = spiderNum3;
		GameData.SceneSpiderNum [3] = spiderNum4;
		GameData.SceneSpiderNum [4] = spiderNum5;
		GameData.SceneSpiderNum [5] = spiderNum6;

		writer3.WriteLine (spiderNum1.ToString());
		writer3.WriteLine (spiderNum2.ToString());
		writer3.WriteLine (spiderNum3.ToString());
		writer3.WriteLine (spiderNum4.ToString());
		writer3.WriteLine (spiderNum5.ToString());
		writer3.WriteLine (spiderNum6.ToString());
		writer3.Close ();
		//Debug.Log ("SceneName: "+GameData.SceneName[0]);
		/*Debug.Log ("Choice1: "+Choices1 +"  "+"Spider: "+spider1+" "+"Cup: "+cup1);
		Debug.Log ("Choice2: "+Choices2 +"  "+"Spider: "+spider2+" "+"Cup: "+cup2);
		Debug.Log ("Choice3: "+Choices3 +"  "+"Spider: "+spider3+" "+"Cup: "+cup3);
		Debug.Log ("Choice4: "+Choices32 +"  "+"Spider: "+spider32+" "+"Cup: "+cup32);
		Debug.Log ("Choice5: "+Choices22 +"  "+"Spider: "+spider22+" "+"Cup: "+cup22);
		Debug.Log ("Choice6: "+Choices12 +"  "+"Spider: "+spider12+" "+"Cup: "+cup12);
		*/
	}

	public void Cancel1Pressed(){
		GameObject.Find ("Choice1").GetComponent<Text> ().text = "Empty";
		GameObject.Find ("Cup1").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider1").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("InputField1").GetComponent<InputField> ().text = "";
		GameData.SceneName [0] = "Empty";
		GameData.SceneSpider [0] = false;
		GameData.SceneCup [0] = false;
		GameData.SceneSpiderNum [0] = "0";
		Debug.Log ("Cancel1 is pressed");
	}
	
	public void Cancel2Pressed(){
		GameObject.Find ("Choice2").GetComponent<Text> ().text = "Empty";
		GameObject.Find ("Cup2").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider3").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("InputField2").GetComponent<Text> ().text = "0";
		GameData.SceneName [1] = "Empty";
		GameData.SceneSpider [1] = false;
		GameData.SceneCup [1] = false;
		GameData.SceneSpiderNum [1] = "0";
	}
	
	public void Cancel3Pressed(){
		GameObject.Find ("Choice3").GetComponent<Text> ().text = "Empty";
		GameObject.Find ("Cup3").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider3").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("InputField3").GetComponent<Text> ().text = "0";
		GameData.SceneName [2] = "Empty";
		GameData.SceneSpider [2] = false;
		GameData.SceneCup [2] = false;
		GameData.SceneSpiderNum [2] = "0";
	}
	
	public void Cancel4Pressed(){
		GameObject.Find ("Choice12").GetComponent<Text> ().text = "Empty";
		GameObject.Find ("Cup12").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider12").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("InputField4").GetComponent<Text> ().text = "0";
		GameData.SceneName [3] = "Empty";
		GameData.SceneSpider [3] = false;
		GameData.SceneCup [3] = false;
		GameData.SceneSpiderNum [3] = "0";
	}
	
	public void Cancel5Pressed(){
		GameObject.Find ("Choice22").GetComponent<Text> ().text = "Empty";
		GameObject.Find ("Cup22").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider22").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("InputField5").GetComponent<Text> ().text = "0";
		GameData.SceneName [4] = "Empty";
		GameData.SceneSpider [4] = false;
		GameData.SceneCup [4] = false;
		GameData.SceneSpiderNum [4] = "0";
	}
	
	public void Cancel6Pressed(){
		GameObject.Find ("Choice32").GetComponent<Text> ().text = "Empty";
		GameObject.Find ("Cup32").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("Spider32").GetComponent<Toggle> ().isOn = false;
		GameObject.Find ("InputField6").GetComponent<Text> ().text = "0";
		GameData.SceneName [5] = "Empty";
		GameData.SceneSpider [5] = false;
		GameData.SceneCup [5] = false;
		GameData.SceneSpiderNum [5] = "0";
	}
}
