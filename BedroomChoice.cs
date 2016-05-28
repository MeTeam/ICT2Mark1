using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;

public class BedroomChoice : MonoBehaviour {
	//public MasterData GameData;
	GameObject myButton;
	public InputField field1;
	public InputField field2;
	public InputField field3;
	public InputField field4;
	public InputField field5;
	public InputField field6;
	/*public int Choice1;
	public int Choice2;
	public int Choice3;
	public int Choice4;
	public int Choice5;
	public int Choice6;
	public int Choice7;
	*/
	public int done;


	public void Cancel1Pressed(){
		string buttonName = (string)GameObject.Find ("Choice1").GetComponent<Text> ().text;
		GameObject buttonx = GameObject.Find (buttonName);
		if (buttonx.GetComponent<Button> ().interactable ==false) {
			buttonx.GetComponent<Button> ().interactable =true;
		}
		
		GameObject.Find ("Choice1").GetComponent<Text> ().text = "Empty";
		field1.text="0";
		Debug.Log ("Kill: me");

		bool test1 = GameObject.Find ("Cup1").GetComponent<Toggle> ().isOn;
		if(test1){
			GameObject.Find ("Cup1").GetComponent<Toggle> ().isOn = false;
		}
		bool test11 = GameObject.Find ("Spider1").GetComponent<Toggle> ().isOn;
		if(test11){
			GameObject.Find ("Spider1").GetComponent<Toggle> ().isOn = false;
		}
	}

	public void Cancel2Pressed(){
		string buttonName = (string)GameObject.Find ("Choice2").GetComponent<Text> ().text;
		GameObject buttonx = GameObject.Find (buttonName);
		//buttonx.GetComponent<Button> ().interactable = true;
		if (buttonx.GetComponent<Button> ().interactable ==false) {
			buttonx.GetComponent<Button> ().interactable =true;
		}

		field2.text="0";
		GameObject.Find ("Choice2").GetComponent<Text> ().text = "Empty";
		bool test1 = GameObject.Find ("Cup2").GetComponent<Toggle> ().isOn;
		if(test1){
			GameObject.Find ("Cup2").GetComponent<Toggle> ().isOn = false;
		}
		bool test11 = GameObject.Find ("Spider2").GetComponent<Toggle> ().isOn;
		if(test11){
			GameObject.Find ("Spider2").GetComponent<Toggle> ().isOn = false;
		}
	}

	public void Cancel3Pressed(){
		string buttonName = (string)GameObject.Find ("Choice3").GetComponent<Text> ().text;
		GameObject buttonx = GameObject.Find (buttonName);
		//buttonx.GetComponent<Button> ().interactable = true;
		if (buttonx.GetComponent<Button> ().interactable ==false) {
			buttonx.GetComponent<Button> ().interactable =true;
		}

		field3.text="0";
		GameObject.Find ("Choice3").GetComponent<Text> ().text = "Empty";
		bool test1 = GameObject.Find ("Cup3").GetComponent<Toggle> ().isOn;
		if(test1){
			GameObject.Find ("Cup3").GetComponent<Toggle> ().isOn = false;
		}
		bool test11 = GameObject.Find ("Spider3").GetComponent<Toggle> ().isOn;
		if(test11){
			GameObject.Find ("Spider3").GetComponent<Toggle> ().isOn = false;
		}
	}

	public void Cancel4Pressed(){
		string buttonName = (string)GameObject.Find ("Choice12").GetComponent<Text> ().text;
		GameObject buttonx = GameObject.Find (buttonName);
		//buttonx.GetComponent<Button> ().interactable = true;
		if (buttonx.GetComponent<Button> ().interactable ==false) {
			buttonx.GetComponent<Button> ().interactable =true;
		}

		field4.text="0";
		GameObject.Find ("Choice12").GetComponent<Text> ().text = "Empty";
		bool test1 = GameObject.Find ("Cup6").GetComponent<Toggle> ().isOn;
		if(test1){
			GameObject.Find ("Cup6").GetComponent<Toggle> ().isOn = false;
		}
		bool test11 = GameObject.Find ("Spider6").GetComponent<Toggle> ().isOn;
		if(test11){
			GameObject.Find ("Spider6").GetComponent<Toggle> ().isOn = false;
		}
	}

	public void Cancel5Pressed(){
		string buttonName = (string)GameObject.Find ("Choice22").GetComponent<Text> ().text;
		GameObject buttonx = GameObject.Find (buttonName);
		//buttonx.GetComponent<Button> ().interactable = true;
		if (buttonx.GetComponent<Button> ().interactable ==false) {
			buttonx.GetComponent<Button> ().interactable =true;
		}

		field5.text="0";
		GameObject.Find ("Choice22").GetComponent<Text> ().text = "Empty";
		bool test1 = GameObject.Find ("Cup5").GetComponent<Toggle> ().isOn;
		if(test1){
			GameObject.Find ("Cup5").GetComponent<Toggle> ().isOn = false;
		}
		bool test11 = GameObject.Find ("Spider5").GetComponent<Toggle> ().isOn;
		if(test11){
			GameObject.Find ("Spider5").GetComponent<Toggle> ().isOn = false;
		}
	}

	public void Cancel6Pressed(){
		string buttonName = (string)GameObject.Find ("Choice32").GetComponent<Text> ().text;
		GameObject buttonx = GameObject.Find (buttonName);
//		buttonx.GetComponent<Button> ().interactable = true;
		if (buttonx.GetComponent<Button> ().interactable ==false) {
			buttonx.GetComponent<Button> ().interactable =true;
		}

		field6.text="0";
		GameObject.Find ("Choice32").GetComponent<Text> ().text = "Empty";
		bool test1 = GameObject.Find ("Cup4").GetComponent<Toggle> ().isOn;
		if(test1){
			GameObject.Find ("Cup4").GetComponent<Toggle> ().isOn = false;
		}
		bool test11 = GameObject.Find ("Spider4").GetComponent<Toggle> ().isOn;
		if(test11){
			GameObject.Find ("Spider4").GetComponent<Toggle> ().isOn = false;
		}
	}

	public void getButtonName(){
		done = 0;
		string buttonName = EventSystem.current.currentSelectedGameObject.name;
		Debug.Log (buttonName);
		myButton = GameObject.Find (buttonName);
		if (myButton.GetComponent<Button> ().IsInteractable () == true) {
			myButton.GetComponent<Button> ().interactable = false;
			Debug.Log ("Jadi");
		}



		string ch = GameObject.Find ("Choice1").GetComponent<Text> ().text;
		if(ch == "Empty" && done==0){
			Debug.Log("jadi");
			GameObject.Find ("Choice1").GetComponent<Text> ().text=buttonName;
			ch="";
			done=1;
		}
		ch = GameObject.Find ("Choice2").GetComponent<Text> ().text;
		if(ch == "Empty" && done==0){
			Debug.Log("jadi2");
			GameObject.Find ("Choice2").GetComponent<Text> ().text=buttonName;
			ch="";
			done=1;
		}
		ch = GameObject.Find ("Choice3").GetComponent<Text> ().text;
		if(ch == "Empty" && done==0){
			Debug.Log("jadi2");
			GameObject.Find ("Choice3").GetComponent<Text> ().text=buttonName;
			ch="";
			done=1;
		}
		ch = GameObject.Find ("Choice12").GetComponent<Text> ().text;
		if(ch == "Empty" && done==0){
			Debug.Log("jadi2");
			GameObject.Find ("Choice12").GetComponent<Text> ().text=buttonName;
			ch="";
			done=1;
		}
		ch = GameObject.Find ("Choice22").GetComponent<Text> ().text;
		if(ch == "Empty" && done==0){
			Debug.Log("jadi2");
			GameObject.Find ("Choice22").GetComponent<Text> ().text=buttonName;
			ch="";
			done=1;
		}
		ch = GameObject.Find ("Choice32").GetComponent<Text> ().text;
		if(ch == "Empty" && done==0){
			Debug.Log("jadi2");
			GameObject.Find ("Choice32").GetComponent<Text> ().text=buttonName;
			ch="";
			done=1;
		}



			/*Choice1 = GameObject.Find ("Choice1").GetComponent<Choice1> ().isFilled1;
			if (Choice1 == 0) {
				GameObject.Find ("Choice1").GetComponent<Text> ().text = buttonName;
				Choice1 = 1;
				//done=1;
				//break;
			}

			Choice2 = GameObject.Find ("Choice2").GetComponent<Choice2> ().isFilled2;
			if (Choice2 == 0) {
				GameObject.Find ("Choice2").GetComponent<Text> ().text = buttonName;
				Choice2 = 1;
				//done=1;
				//break;
			}

			Choice3 = GameObject.Find ("Choice3").GetComponent<Choice3> ().isFilled3;
			if (Choice3 == 0) {
				GameObject.Find ("Choice3").GetComponent<Text> ().text = buttonName;
				Choice3 = 1;
				//done=1;
				//break;
			}

			Choice4 = GameObject.Find ("Choice32").GetComponent<Choice32> ().isFilled32;
			if (Choice4 == 0) {
				GameObject.Find ("Choice32").GetComponent<Text> ().text = buttonName;
				Choice4 = 1;
				//done=1;
				//break;
			}

			Choice5 = GameObject.Find ("Choice22").GetComponent<Choice22> ().isFilled22;
			if (Choice5 == 0) {
				GameObject.Find ("Choice22").GetComponent<Text> ().text = buttonName;
				Choice5 = 1;
				//done=1;
				//break;
			}

			Choice6 = GameObject.Find ("Choice12").GetComponent<Choice12> ().isFilled12;
			if (Choice6 == 0) {
				GameObject.Find ("Choice12").GetComponent<Text> ().text = buttonName;
				Choice6 = 1;
				//done=1;
				//break;
			}
		}*/
	}

	

}