using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {
	public Transform[] spawnPoint;
	public GameObject[] objectSpawnPrefab;
	public GameObject[] objectSpawnClone;
	public List<int> numbers;


	// Use this for initialization
	void Start () {
		numbers = new List<int>();
		randomNum ();
		/*Debug.Log (numbers[0]);
		Debug.Log (numbers[1]);
		Debug.Log (numbers[2]);*/	
		spawnObject ();

	}
	
	// Update is called once per frame
	void spawnObject(){
		for (int i=0; i<objectSpawnPrefab.Length; i++) {
			if(objectSpawnPrefab[i].name=="trophe 1"){
				float x=spawnPoint[numbers[i]].position.x;
				float y=spawnPoint[numbers[i]].position.y+2;
				float z=spawnPoint[numbers[i]].position.z;
				Vector3 pos=new Vector3(x,y,z);
				objectSpawnClone[i]= (GameObject)Instantiate(objectSpawnPrefab[i],pos,Quaternion.Euler(0,120,270));
			}
			else{
			objectSpawnClone[i]= (GameObject)Instantiate(objectSpawnPrefab[i],spawnPoint[numbers[i]].transform.position,Quaternion.Euler(0,0,0));
			}
		}

	}

	void randomNum(){
		int a = 0;
		//Debug.Log (numbers.Count);
		while(numbers.Count<=3){    
			a = Random.Range (0, 6);
			if(!numbers.Contains(a)) {
				numbers.Add(a);
			}
		}
	}
}


