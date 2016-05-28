using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LibraryScript : MonoBehaviour {

	public void insertName1(){
		Debug.Log (EventSystem.current.currentSelectedGameObject.name);
	}
	public void insertName2(){
		Debug.Log (EventSystem.current.currentSelectedGameObject.name);
	}
}
